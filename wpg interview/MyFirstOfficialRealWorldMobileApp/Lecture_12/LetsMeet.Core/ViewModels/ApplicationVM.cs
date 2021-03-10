using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMeet.Core
{
   public class ApplicationVM: BaseViewModel
    {
        //private static ApplicationVM Instance = new ApplicationVM();

        //public static ApplicationVM instance => Instance;


        private ApplicationType currentPage = ApplicationType.LoginPage;

        public ApplicationType CurrentPage
        {
            get
            {

                return currentPage;
            }
            set
            {
                currentPage = value;
                OnPropertyChanged("CurrentPage");

            }
        }


        public bool sideMenuVisible  = true;
        public bool SideMenuVisible
        {
            get
            {

                return sideMenuVisible;
            }
            set
            {
                sideMenuVisible = value;
                OnPropertyChanged("SideMenuVisible");

            }
        }

        public ApplicationVM()
        {

        }
    }
}
