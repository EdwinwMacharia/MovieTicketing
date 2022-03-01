﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MovieTicketing.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange();
                }

                if (!context.Actors.Any())
                {

                }

                if (!context.Movies.Any())
                {

                }

                if (!context.Producers.Any())
                {

                }

            }

        }
    }
}
