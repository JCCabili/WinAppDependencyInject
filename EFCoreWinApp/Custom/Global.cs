using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace EFCoreWinApp.Custom
{
    public static class Global
    {
        private static IUnityContainer _container;
        public static IUnityContainer Container
        {
            get { return _container; }
            set { _container = value; }
        }
    }
}
