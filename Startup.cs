using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tamin.Areas.Identity;
using Tamin.Data.Models;
using Tamin.Data;
using Tamin.Entities;
using Tamin.Services;
using Microsoft.AspNetCore.Components.Authorization;

namespace Tamin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>(config =>
            {
                config.SignIn.RequireConfirmedEmail = true;
                config.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            services.AddRazorPages()
            .AddRazorPagesOptions(options =>
             {
                 options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
                 options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
             });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });
            
            services.AddServerSideBlazor(opts => opts.DetailedErrors = true);
            services.AddTelerikBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddOptions();
            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            services.AddSingleton<IEmailSender, EmailSender>();
            services.AddScoped<IVendorData, VendorData>();
            services.AddScoped<ISqlDataAccess, SqlDataAccess>();
            services.AddScoped<IActivityData, ActivityData>();
            services.AddScoped<IGroupsData, GroupsData>();
            services.AddScoped<IAssessmentFCData, AssessmentFCData>();
            services.AddScoped<IAssessmentFSData, AssessmentFSData>();
            services.AddScoped<IAssessmentFPEData, AssessmentFPEData>();
            services.AddScoped<IAssessmentSCData, AssessmentSCData>();
            services.AddScoped<IAssessmentSSData, AssessmentSSData>();
            services.AddScoped<IAssessmentSPEData, AssessmentSPEData>();
            services.AddScoped<IINAssessmentFCData, INAssessmentFCData>();
            services.AddScoped<IINAssessmentFSData, INAssessmentFSData>();
            services.AddScoped<IINAssessmentFPEData, INAssessmentFPEData>();
            services.AddScoped<IINAssessmentSCData, INAssessmentSCData>();
            services.AddScoped<IINAssessmentSSData, INAssessmentSSData>();
            services.AddScoped<IINAssessmentSPEData, INAssessmentSPEData>();
            services.AddScoped<IProjectsData, ProjectsData>();
            services.AddScoped<IDateData, DateData>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
       }
}
