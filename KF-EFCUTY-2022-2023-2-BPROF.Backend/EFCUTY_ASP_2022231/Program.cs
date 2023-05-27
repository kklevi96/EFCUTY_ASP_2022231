using EFCUTY_ASP_2022231.Data;
using EFCUTY_ASP_2022231.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EFCUTY_ASP_2022231.Repository;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-EFCUTY_ASP_2022231-B0C829E2-7F2E-44B5-85BF-7FE7180D6587;Trusted_Connection=True;MultipleActiveResultSets=true";
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options
    .UseSqlServer(connectionString)
    .UseLazyLoadingProxies());
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddTransient<ISubjectsRepository, SubjectsRepository>();
builder.Services.AddTransient<IPostsRepository, PostsRepository>();
builder.Services.AddTransient<ICommentsRepository, CommentsRepository>();

//builder.Services.AddDefaultIdentity<SiteUser>(options =>
//{
//    options.SignIn.RequireConfirmedAccount = false;
//    options.Password.RequireDigit = false;
//    options.Password.RequiredLength = 8;
//    options.Password.RequireNonAlphanumeric = false;
//    options.Password.RequireUppercase = false;

//})
//    .AddRoles<IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddIdentity<ApiUser, IdentityRole>(option =>
{
    option.SignIn.RequireConfirmedAccount = false;
    option.Password.RequireDigit = false;
    option.Password.RequiredLength = 8;
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequireUppercase = false;
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

builder.Services.AddAuthentication().AddFacebook(opt =>
{
    opt.AppId = "399971805603613";
    opt.AppSecret = "22aea2df6af2c47164f053b7e5fa1b7e";
});

builder.Services.AddControllersWithViews();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithHeaders("*");
            policy.WithOrigins("*");
            policy.WithMethods("*");
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
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
app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Subjects}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
