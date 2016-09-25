// HelloNunit.HelloNunit.Bootstrapper.cs

using Castle.Facilities.TypedFactory;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace HelloNunit.Bootstrap
{
    public static class Bootstrapper
    {
        public static IWindsorContainer Bootstrap()
        {
            // The bootstrapper is the entry point for Castle Windsor configuration.
            // Create a new WindsorContainer instance
            var container = new WindsorContainer();

            // Configure the TypedFactoryFacility, which enables us to register interfaces
            // as factories and have Windsor provide an implementation at runtime.
            container.AddFacility<TypedFactoryFacility>();

            // Basically says "Hey Windsor - Look at this assembly and find all the classes
            // that implement IWindsorInstaller and call their Install method.  Effectively this
            // is what ends up populating the container with types.
            container.Install(FromAssembly.This());

            // The caller will need the container in order to resolve the composition root.
            return container;
        }
    }
}