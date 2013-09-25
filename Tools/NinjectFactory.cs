namespace DIR
{
    using Controller;
    using Controller.Abstract;
    using DAL;
    using DAL.Abstract;
    using Ninject;

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
