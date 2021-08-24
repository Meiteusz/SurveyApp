using Models;
using Models.Entities.Interfaces;
using Ninject;
using Ninject.Modules;
using System.Reflection;

namespace InjectionModules
{
    public class OccurrenceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOccurrence>().To<Occurrence>();
        }

        public static IOccurrence ConfiguratingModule()
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            return kernel.Get<IOccurrence>();
        }
    }
}
