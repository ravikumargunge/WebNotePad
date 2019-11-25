using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebNotePad.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
      
        public static void AddDataAccessServies(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));
        }
    }
}
