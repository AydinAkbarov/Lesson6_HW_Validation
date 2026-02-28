using FluentValidation.AspNetCore;
using Lesson6_asp_hw.Services.Abstracts;
using Lesson6_asp_hw.Services.Concretes;
using Lesson6_asp_hw.Validations.FluentValidations;

var builder = WebApplication.CreateBuilder(args);

builder.Services
       .AddControllersWithViews()
       .AddFluentValidation(cfg =>
       {
           cfg.RegisterValidatorsFromAssemblyContaining<UserValidator>();
       });

builder.Services.AddScoped<IRepository, UserRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
