﻿using Microsoft.Extensions.DependencyInjection;
using RemotableInterface;
using RemotableInterfaces;
using RemotableInterfactes;
using RemotableObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemotableServer
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRemoting(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddScoped<INetListenerHandle>(sp => new NetListenerHandler())
                .AddScoped<INetSenderHandler>(sp => new NetSenderHandler())
                .AddScoped<IClientProxy, ClientProxy>();
        }
    }
}
