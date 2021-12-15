using EasyTabs;
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
    public partial class app_cen : TitleBarTabs
    {
        public app_cen()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        [Obsolete]
    #pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
        public override TitleBarTab CreateTab()
    #pragma warning restore CS0809 // Obsolete member overrides non-obsolete member
        {

            return new TitleBarTab(this)
            {

                Content = new FrmBrowser
                {

                    Text = "Crystalium Browser"
                }
            };
        }
    }
}
