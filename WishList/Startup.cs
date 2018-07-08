﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WishList.Data;

namespace WishList
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); //add the support for MVC function 
            services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("WishList"));
            //In the ConfigureServices method, call AddDbContext<ApplicationDbContext> on services with the 
            //argument options => options.UseInMemoryDatabase("WishList") to point EntityFramework to the application's DbContext. 
            //(Note: You will need to add a using statement for WishList.Data)
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // this will give better detail error page.
            }
                else
            {
                app.UseExceptionHandler("/Home/Error");
            }
                app.UseMvcWithDefaultRoute(); //so the startup flow goes intpmvc defualt route
            ;
        }
    }
}
