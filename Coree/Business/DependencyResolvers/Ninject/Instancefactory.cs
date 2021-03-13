using System;
using Ninject;
using Ninject.Modules;

namespace Coree.Business.DependencyResolvers.Ninject
{  
    public class Instancefactory
    {
        public static T GetInstance<T>(NinjectModule module)
        {
            var kernel=new StandardKernel(module);
            return kernel.Get<T>();
        }

        public static object GetInstance()
        {
            throw new NotImplementedException();
        }
    }
}
