using BehaviouralTest.WebUI.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowPages.Pages
{
    public class DomainNavigationPage
    {
        static DomainNavigationPage()
        {
            Driver.Initialize();
        }
        public static void GoTo(string URL)
        {
            
        }
        /// TO DO  - Method shoud be moved into Base Page
        public static void VerifyPageTitle(string title)
        {
            //Driver.WebDriverInstance.Title
        }
        
    }
}
