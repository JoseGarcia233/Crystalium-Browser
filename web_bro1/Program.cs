using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_bro1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            app_cen CONTE = new app_cen();

            CONTE.Tabs.Add(

                new TitleBarTab(CONTE)
                {
                    Content = new FrmBrowser
                    {
                        Text = "Crystalium Browser"
                    }

                }


                );


            CONTE.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(CONTE);
            Application.Run(applicationContext);



           


            

        }
    }
}
