using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BasicBackgrounf
{
  public class MainWindowVM: BaseViewModel
    {
        #region Private Properties

        private int innerPadding = 10;

        #endregion

        #region Public Properties
        public Thickness InnerPadding { get { return new Thickness(innerPadding); } }

        public int CornerRadius { get; set; } = 15;

        public CornerRadius CornerRadiusValue { get { return new CornerRadius(CornerRadius+ innerPadding); } }

        public int captionHeight { get; set; } = 6;

        public int TitleHeight { get; set; } = 50;

        public int ShadowHeight { get; set; } = 2;

        public int resizeBorderDistance { get { return innerPadding + 10; }}

        public ApplicationType CurrentPage { get; set; } = ApplicationType.LoginPage;

        #endregion

        public MainWindowVM()
        {
                
        }

    }
}
