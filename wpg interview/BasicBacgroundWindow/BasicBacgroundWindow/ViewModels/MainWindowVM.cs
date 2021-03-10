using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BasicBacgroundWindow
{
   public class MainWindowVM: BaseVM
    {

        private int innerPadding = 10;

        public Thickness InnerPadding { get { return new Thickness(innerPadding); } }


        private int cornerRadius = 10;

        public CornerRadius CornerRadius { get { return new CornerRadius(innerPadding + cornerRadius); } }


        private int headerHeight = 30;

        public GridLength HeaderHeight { get { return new GridLength(headerHeight); } }


        private int dropShadowHeight = 100;

        public GridLength DropShadowHeight { get { return new GridLength(dropShadowHeight); } }


        public int HeaderDragLength { get { return headerHeight+ innerPadding; } }


        private int resizeThickness = 10;

        public int ResizeThickness { get { return resizeThickness; } }


        public ApplicationType CurrentPage { get; set; } = ApplicationType.LoginPage;



        public MainWindowVM()
        {

        }
    }
}
