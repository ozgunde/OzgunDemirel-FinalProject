using Microsoft.Extensions.DependencyInjection;
using Music.Business.Mapper;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Music.Business.Extensions
{
    public static class MappingRegistration
    {
        public static IServiceCollection AddMapperConfiguration(this IServiceCollection services)
        {
            return services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
