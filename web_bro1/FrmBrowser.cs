using EasyTabs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_bro1
{
    public partial class FrmBrowser : Form
    {
        [Obsolete]
        public FrmBrowser()
        {
            InitializeComponent();

            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 11001, RegistryValueKind.DWord);


            webBrowser1.Navigate("https://www.google.com.do/");
        }

        protected TitleBarTabs ParentTabs
        {

            get
            {

                return (ParentTabs as TitleBarTabs);
            }

        }



        private void explorerBrowser1_Load(object sender, EventArgs e)
        {

        }

        private void FrmBrowser_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

            
            webBrowser1.Navigate("https://www.google.com.do/");
            
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntBac_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack) webBrowser1.GoBack();
        }

        private void btnFrw_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward) webBrowser1.GoForward();
        }

        private void bunifuTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter&& bunifuTextBox1.Text.Trim().Length > 0)
            {
                if (bunifuTextBox1.Text.Contains("."))
                {

                   
                     webBrowser1.Navigate(bunifuTextBox1.Text.Trim());

                }
                else
                {
                    webBrowser1.Navigate("https://www.google.com/search?client=opera&q=" + bunifuTextBox1.Text.Trim().Replace("", "+") + "&sourceid=opera&ie=UTF-8&oe=UTF-8");
                }
            }
        }
        //"+bunifuTextBox1.Text.Trim().Replace("","+")+"

        //

        //private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        //{
        //    btnRfr.Image = SnippIma.Image;
        //}

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //btnRfr.Image = RefreImg.Image;

            bunifuTextBox1.Text = webBrowser1.Url.AbsoluteUri;
        }

        private void webBrowser2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
