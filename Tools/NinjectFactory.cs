// -----------------------------------------------------------------------
// <copyright file="NinjectContainer.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Tools
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Ninject;
    using Controller;
    using Controller.Abstract;
    using Controller.Concrete;
    using DAL.Abstract;
    using DAL;
    using Ninject.Modules;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class NinjectFactory
    {
        private static StandardKernel kernel;

        static NinjectFactory()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        private static void AddBindings()
        {
            kernel.Bind<IRepository>().To<Repository>();
        }

        public static T Resolve<T>()
        {
            return kernel.Get<T>();
        }

        public static T Resolve<T>(object caller)
        {
            kernel.Bind<IController>().To<ControllerClass>().WithConstructorArgument("view", caller);
            return kernel.Get<T>();
        }
    }
}
