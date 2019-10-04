using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Yvz.Northwind.Business.Abstract;
using Yvz.Northwind.Business.Concrete;
using Yvz.Northwind.DataAccess.Abstract;
using Yvz.Northwind.DataAccess.Concrete.EntityFramework;
using Yvz.Northwind.MVCWebUI.Entities;
using Yvz.Northwind.MVCWebUI.Middlewares;
using Yvz.Northwind.MVCWebUI.Services;

namespace Yvz.Northwind.MVCWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddSingleton<ICartService, CartService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<CustomIdentityDbContext>(options =>
                options.UseSqlServer("Data Source=MUSTAFA;Initial Catalog=Northwind;Integrated Security=true;"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //statik dosya yönetimi için kullanılır css ve js dosyalar için.
            app.UseFileServer();

            app.UseNodeModules(env.ContentRootPath);

            app.UseIdentity();

            //session middleware
            app.UseSession();

            //home/index root gider.
            app.UseMvcWithDefaultRoute();
        }
    }
}
