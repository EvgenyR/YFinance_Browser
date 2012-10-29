using System;
using System.Windows.Forms;
using System.Data.Objects;

namespace Finance
{
    public partial class MainForm : Form
    {
        FinanceEntities db;
        FinanceBrowser fb;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "ttester414@yahoo.com";
            txtPassword.Text = "123456";
            lblCookies.Text = string.Empty;

            db = new FinanceEntities();
            fb = new FinanceBrowser(db);
            fb.DataDownloaded += new FinanceBrowser.EventHandler(fb_DataDownloaded);
            fb.Authenticated += new FinanceBrowser.EventHandler(fb_Authenticated);

            ObjectSet<Symbol> symbols = db.Symbols;
            symbolBindingSource.DataSource = symbols;

            SetDatumSource();
        }

        void fb_Authenticated(object sender, EventArgs args)
        {
            lblCookies.Text = "Authenticated";
        }

        void fb_DataDownloaded(object sender, EventArgs args)
        {
            SetDatumSource();
        }

        private void SetDatumSource()
        {
            FinanceEntities datumDb = new FinanceEntities();
            ObjectSet<Datum> datum = datumDb.Data;
            datumBindingSource.DataSource = datum;
            datumBindingSource.ResetBindings(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
                MessageBox.Show("Changes Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            fb.Login = txtUsername.Text;
            fb.Password = txtPassword.Text;
            fb.Authenticate();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            fb.DownloadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fb.StopDownloading();
        }
    }
}
