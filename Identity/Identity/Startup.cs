using Identity.IdentityPolicy;
using Identity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Identity
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPasswordValidator<AppUser>, CustomPasswordPolicy>();
            services.AddTransient<IUserValidator<AppUser>, CustomUsernameEmailPolicy>();
            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddTransient<IAuthorizationHandler, AllowUsersHandler>();
            services.AddTransient<IAuthorizationHandler, AllowPrivateHandler>();
            services.AddAuthorization(opts => {
                opts.AddPolicy("AspManager", policy => {
                    policy.RequireRole("Manager");
                    policy.RequireClaim("Coding-Skill", "ASP.NET Core MVC");
                });
            });
            services.AddAuthorization(opts => {
                opts.AddPolicy("AllowTom", policy => {
                    policy.AddRequirements(new AllowUserPolicy("tom"));
                });
            });
            services.AddAuthorization(opts => {
                opts.AddPolicy("PrivateAccess", policy => {
                    policy.AddRequirements(new AllowPrivatePolicy());
                });
            });
            services.AddAuthentication().AddGoogle(opts => {
                opts.ClientId = "280902487776-8re3f4rmntj07sl8ikd3k4vmkfi339kv.apps.googleusercontent.com";
                opts.ClientSecret = "0VY64UmrEsbBgizNNkgN9xw_";
                //opts.ClientId = "174861462797-s3fdn0kqn6egf8a4n13sdrdr2vblroc2.apps.googleusercontent.com";
                //opts.ClientSecret = "cwrRKYDgsRA7bTJAHpQnZH35";
                //opts.CallbackPath = "/Account/GoogleResponse";
            });
            //services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppIdentityDbContext>().AddDefaultTokenProviders();
            services.AddIdentity<AppUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                //opts.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz";
                opts.Password.RequiredLength = 8;
                opts.Password.RequireNonAlphanumeric = true;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = true;
                opts.Password.RequireDigit = true;
            }).AddEntityFrameworkStores<AppIdentityDbContext>().AddDefaultTokenProviders();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
        }
    }
}
