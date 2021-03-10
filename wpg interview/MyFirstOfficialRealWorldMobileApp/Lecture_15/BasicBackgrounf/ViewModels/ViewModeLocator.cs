using LetsMeet.Core;
using LetsMeet.Core.IoC;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMeet
{
    public  class ViewModeLocator
    {
        public static ViewModeLocator Instance => new ViewModeLocator();
        public static ApplicationVM ApplicationVM => IoCContainer.Kernel.Get<ApplicationVM>();
    }
}
