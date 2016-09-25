// HelloNunit.HelloNunit.HelloNunitInstaller.cs

using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using HelloNunit.Factories;
using HelloNunit.FrameworkWrappers;

namespace HelloNunit.Bootstrap
{
    public class HelloNunitInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            // This code registers types with Castle Windsor so that it can resolve them as needed.
            // This line registers the IConsoleWriter implementation as a singleton, so only one instance
            // will be created and reused everywhere an IConsoleWriter is needed.
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>().LifeStyle.Singleton);

            // This line registers ILoggerFactory as an abstract factory.  Windsor will provide
            // an implementation for us at runtime, allowing us to eliminate the concrete
            // LoggerFactory type.
            // This feature requires the Windsor TypedFactoryFacility to be installed.
            container.Register(Component.For<ILoggerFactory>().AsFactory());

            // This line registers both types implementing ILogger so they can be resolved
            // by ILoggerFactory at runtime.
            container.Register(Component.For<ILogger>().ImplementedBy<BitBucketLogger>(),
                Component.For<ILogger>().ImplementedBy<ConsoleLogger>());

            // This line registers IGreeter as Transient, meaning that each time the container 
            // needs to resolve an IGreeter, a new Greeter instance will be created.
            container.Register(Component.For<IGreeter>().ImplementedBy<Greeter>().LifeStyle.Transient);
        }
    }
}