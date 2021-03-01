using Eprescription.Core;
using Eprescription.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Eprescription
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<EprescriptionDbContext>(options => options.UseSqlServer("Server=.;Database=EprescriptionDbContext;Trusted_Connection=True;"));
            
            services.AddTransient<IDoctorRepository, DoctorRepository>();
            services.AddTransient<IPrescriptionRepository, PrescriptionRepository>();
            services.AddTransient<IMedicineRepository, MedicineRepository>();

            services.AddTransient<IDoctorDtoMapper, DoctorDtoMapper>();
            services.AddTransient<IMedicineDtoMapper, MedicineDtoMapper>();
            services.AddTransient<IPrescriptionDtoMapper, PrescriptionDtoMapper>();
            services.AddTransient<IMedicinePrescriptionDtoMapper, MedicinePrescriptionDtoMapper>();

            services.AddTransient<IDoctorManager, DoctorManager>();
            services.AddTransient<IPrescriptionManager, PrescriptionManager>();
            services.AddTransient<IMedicineManager, MedicineManager>();

            services.AddTransient<IDoctorViewModelMapper, DoctorViewModelMapper>();
            services.AddTransient<IMedicineViewModelMapper, MedicineViewModelMapper>();
            services.AddTransient<IPrescriptionViewModelMapper, PrescriptionViewModelMapper>();
            services.AddTransient<IMedicinePrescriptionViewModelMapper, MedicinePrescriptionViewModelMapper>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            var database = serviceProvider.GetService<EprescriptionDbContext>();
            database.Database.Migrate();
        }
    }
}
