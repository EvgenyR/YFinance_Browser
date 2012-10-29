using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.Objects;
using System.Globalization;

namespace Finance
{
    public class FinanceBrowser
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); //logging
        public delegate void EventHandler(object sender, EventArgs args);
        public event EventHandler DataDownloaded = delegate { };
        public event EventHandler Authenticated = delegate { };

        private string _login;

        public string Login
        {
            set { _login = value; }
        }
        private string _password;

        public string Password
        {
             set { _password = value; }
        }

        private readonly WebBrowser _browser;
        private const string LoginUrl = "https://login.yahoo.com/config/login";
        private const string MyYahoo = "my.yahoo.com";
        private string _cookies = null;
        private readonly Uri _downloadUrl = null;
        private readonly FinanceEntities _db;
        private readonly Timer _timer;

        public FinanceBrowser(FinanceEntities DB)
        {
            _browser = new WebBrowser();
            _browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(browser_DocumentCompleted);
            _browser.Navigated += new WebBrowserNavigatedEventHandler(browser_Navigated);
            _db = DB;
            _downloadUrl = GetDownloadUrl();

            _timer = new Timer {Interval = 5000};
            _timer.Tick += new System.EventHandler(timer_Tick);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            DownloadData();
        }

        public void Authenticate()
        {
            _browser.Navigate(LoginUrl);
        }

        public void DownloadData()
        {
            _timer.Stop();
            _browser.Url = _downloadUrl;
        }

        private int GetSymbol(string name)
        {
            var symbol = new Symbol();
            try
            {
                symbol = _db.Symbols.Where(s => s.Name == name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                log.Fatal("Could not find Symbol " + name, ex);
            }
            return symbol.Id;
        }

        private Uri GetDownloadUrl()
        {
            // example url: "http://download.finance.yahoo.com/d/quotes.csv?s=ACC.NS+ICICIBANK.NS+ENGINERSI.NS&f=snd1l1t1vb3b2hg"
            string url = "http://download.finance.yahoo.com/d/quotes.csv?s=";

            try
            {
                var urlDb = new FinanceEntities();
                ObjectSet<Symbol> symbols = urlDb.Symbols;
                int total = symbols.Count();
                int count = 0;
                foreach (Symbol symbol in symbols)
                {
                    url = url + symbol.Name;
                    if (count < total - 1)
                    {
                        url = url + "+";
                    }
                    count++;
                }
                url = url + "&f=snd1l1t1vb3b2hg";
            }
            catch(Exception ex)
            {
                log.Fatal("Error retrieving download url: ", ex);
            }
            return new Uri(url);
        }

        private void InsertData(IEnumerable<string> lines)
        {
            try
            {
                foreach (string line in lines)
                {
                    Datum datum = GetDatum(line);
                    _db.Data.AddObject(datum);
                    _db.SaveChanges();
                }
                _db.Refresh(RefreshMode.StoreWins, _db.Data);
                DataDownloaded(this, new EventArgs());
            }
            catch (Exception ex)
            {
                log.Fatal("Exception in InsertData: ", ex);
            }

            _timer.Start();
        }

        private Datum GetDatum(string line)
        {
            var datum = new Datum();
            try
            {
                string[] splitLine = line.Split(',');
                datum = new Datum
                {
                    SymbolId = GetSymbol(splitLine[0].Replace("\"", "")),
                    Name = splitLine[1].Replace("\"", ""),
                    Date =
                        DateTime.ParseExact(splitLine[2].Replace("\"", ""), "MM/dd/yyyy",
                                            CultureInfo.InvariantCulture),
                    LTP = decimal.Parse(splitLine[3]),
                    Time = DateTime.Parse(splitLine[4].Replace("\"", "")),
                    Volume = decimal.Parse(splitLine[5]),
                    Ask = decimal.Parse(splitLine[6]),
                    Bid = decimal.Parse(splitLine[7]),
                    High = decimal.Parse(splitLine[8]),
                    Low = decimal.Parse(splitLine[9])
                };
            }
            catch (Exception ex)
            {
                log.Fatal("Exception in GetDatum: ", ex);
            }
            return datum;
        }

        internal void StopDownloading()
        {
            _timer.Stop();
        }

        #region BrowserEvents

        void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //Successful login takes to "my.yahoo.com"
            if (_browser.Url.AbsoluteUri.Contains(MyYahoo))
            {
                if (_browser.Document != null && !String.IsNullOrEmpty(_browser.Document.Cookie))
                {
                    _cookies = _browser.Document.Cookie;
                    Authenticated(this, new EventArgs());
                }
            }
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //downloaded "quote.csv"
            if(_browser.Url.AbsoluteUri.Contains(".csv"))
            {
                if (_browser.Document != null && _browser.Document.Body != null)
                {
                    string s = _browser.Document.Body.InnerText;
                    string[] strings = s.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    InsertData(strings);
                }
            }

            //loaded the Yahoo login page
            if (_browser.Url.AbsoluteUri.Contains(LoginUrl))
            {
                if (_browser.Document != null)
                {
                    //Find and fill the "username" textbox
                    HtmlElementCollection collection = _browser.Document.GetElementsByTagName("input");
                    foreach (HtmlElement element in collection)
                    {
                        string name = element.GetAttribute("id");
                        if (name == "username")
                        {
                            element.SetAttribute("value", _login);
                            break;
                        }
                    }

                    //Find and fill the "password" field
                    foreach (HtmlElement element in collection)
                    {
                        string name = element.GetAttribute("id");
                        if (name == "passwd")
                        {
                            element.SetAttribute("value", _password);
                            break;
                        }
                    }

                    //Submit the form
                    collection = _browser.Document.GetElementsByTagName("button");
                    foreach (HtmlElement element in collection)
                    {
                        string name = element.GetAttribute("id");
                        if (name == ".save")
                        {
                            element.InvokeMember("click");
                            break;
                        }
                    }
                }
            }
        }

        #endregion
    }
}