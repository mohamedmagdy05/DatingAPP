using DatingApp.Application.Interfaces;
using DatingApp.Application.Services;
using DatingApp.Domain.Interfaces;
using DatingAPP.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.IOC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            services.AddScoped<ICourseServices, CourseServices>();
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
