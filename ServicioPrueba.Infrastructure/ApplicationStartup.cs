using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using Microsoft.Extensions.DependencyInjection;
using ServicioPrueba.Infrastructure.Database;
using ServicioPrueba.Infrastructure.Processing;

namespace ServicioPrueba.Infrastructure
{
    public class ApplicationStartup
    {
        public static void Initialize(
           ContainerBuilder container,
            string connectionString)
        {
            container.RegisterModule(new DataAccessModule(connectionString));
            container.RegisterModule(new MediatorModule());
            container.RegisterModule(new ProcessingModule());
            container.RegisterModule(new SpecificationModule());
        }
    }
}