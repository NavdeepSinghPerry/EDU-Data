using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMeet.Core.IoC
{
   public class IoCContainer
    {
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        public static void Setup()
        {
            BindViewModels();
        }

        private static void BindViewModels()
        {
            // Bind a VM of which only one instance will be created
            Kernel.Bind<ApplicationVM>().ToConstant(new ApplicationVM());
        }

        public static object Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}
