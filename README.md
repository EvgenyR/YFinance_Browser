YFinance_Browser Application
---------------

This application automatically logs into the Yahoo account and requests a comma-separated file. The file is then parsed and the information from the file is stored int the database. The key points of the application are

**Authentication using WebBrowser**

**Utilising the browser_Navigated event**

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

**Utilising the browser_DocumentCompleted event**

    void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
    	//downloaded "quote.csv"
    	if(_browser.Url.AbsoluteUri.Contains(".csv"))
    	{
    		if (_browser.Document != null && _browser.Document.Body != null)
    		{
    			string s = _browser.Document.Body.InnerText;
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

**See also my [blog entry] on the subject**

  [blog entry]: http://justmycode.blogspot.com.au/2012/10/automating-website-authentication.html