using System.Configuration;
using System.Web.Mvc;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;

using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using Ninject.Web.Mvc;

using QuestRoom.Data;
using QuestRoom.Data.Abstractions;
using QuestRoom.Service;
using QuestRoom.Service.Absractions;


namespace QuestRoom.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void RegisterDependencies()
        {
            var module = new Module();
            var kernel = new StandardKernel(module);
            var resolver = new NinjectDependencyResolver(kernel);

            DependencyResolver.SetResolver(resolver);
        }

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
        }

        private static string GetDefaultConnection()
        {
            return ConfigurationManager.AppSettings.Get("defaultConnection");
        }

        private class Module : NinjectModule
        {
            public override void Load()
            {
                Bind<IDataUnitOfWork>()
                    .To<DataUnitOfWork>()
                    .InRequestScope()
                    .WithConstructorArgument("connectionString", GetDefaultConnection());

                Bind<IRoomService>()
                    .To<RoomService>()
                    .InRequestScope();

                Bind<IPictureService>()
                    .To<PictureService>()
                    .InRequestScope();

                Bind<ITypeRoomService>()
                    .To<TypeRoomService>()
                    .InRequestScope();

                Bind<ILevelComplexityService>()
                    .To<LevelComplexityService>()
                    .InRequestScope();
            }
        }
    }
}