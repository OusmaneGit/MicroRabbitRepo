using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using System;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IserviceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
