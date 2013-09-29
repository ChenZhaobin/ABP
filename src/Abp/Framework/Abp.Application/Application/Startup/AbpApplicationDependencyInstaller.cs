﻿using Abp.Application.Services.Interceptors;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Abp.Application.Startup
{
    public class AbpApplicationDependencyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<AbpApplicationServiceInterceptor>()
                );
        }
    }
}