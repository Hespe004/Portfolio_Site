using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio_Site.Areas.Identity.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Portfolio_Site.Data;

namespace Portfolio_Site
{
    public class Startup
    {
   public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();
            services.AddDbContext<_Portfolio_Site_Dbcontext>(options => options.UseSqlite("Data Source=database.db"));
            services.AddRazorPages();
            services.AddIdentity<_Portfolio_Site_User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<_Portfolio_Site_Dbcontext>()
                .AddRoles<IdentityRole>()
                .AddRoleManager<RoleManager<IdentityRole>>();

            services.AddDbContext<_Portfolio_Site_Dbcontext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("Portfolio_Site_Dbcontext")));
        }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapRazorPages();
        });
    }
}
}
