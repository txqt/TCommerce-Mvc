﻿using Microsoft.AspNetCore.Authentication.Cookies;
using System.Text.Json;
using System.Text.Json.Serialization;
using T.Library.Model.Interface;
using T.Library.Model.JwtToken;
using T.Web.Common;
using T.Web.Helpers;
using T.Web.Routing;
using T.Web.Services;
using T.Web.Services.BannerServices;
using T.Web.Services.CategoryService;
using T.Web.Services.Database;
using T.Web.Services.HomePageServices;
using T.Web.Services.PictureServices;
using T.Web.Services.PrepareModel;
using T.Web.Services.PrepareModelServices;
using T.Web.Services.ProductService;
using T.Web.Services.SecurityServices;
using T.Web.Services.UrlRecordService;
using T.Web.Services.UserRegistrationServices;
using T.Web.Services.UserService;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews().AddJsonOptions(options =>
        {
            //options.JsonSerializerOptions.PropertyNamingPolicy = null;
            options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
            options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        }); ;
        builder.Services.AddTransient<JwtHandler>();
        builder.Services.AddHttpClient("", sp =>
        {
            sp.BaseAddress = new Uri(builder.Configuration.GetSection("Url:ApiUrl").Value);
        })
            .AddHttpMessageHandler<JwtHandler>()
            .AddHttpMessageHandler<UnauthorizedResponseHandler>();

        builder.Services.AddTransient<IDatabaseControl, DatabaseControl>();
        builder.Services.AddAutoMapper(typeof(Program).Assembly);
        builder.Services.AddTransient<IUserRegistrationService, UserRegistrationService>();
        builder.Services.AddTransient<IProductService, ProductService>();
        builder.Services.AddTransient<IProductAttributeCommon, ProductAttributeService>();
        builder.Services.AddTransient<ISecurityService, SecurityService>();
        builder.Services.AddTransient<IProductModelService, ProductModelService>();
        builder.Services.AddTransient<ICategoryModelService, CategoryModelService>();
        builder.Services.AddTransient<IBannerModelService, BannerModelService>();
        builder.Services.AddTransient<IUserModelService, UserModelService>();
        builder.Services.AddTransient<ICategoryService, CategoryService>();
        builder.Services.AddTransient<IProductCategoryService, ProductCategoryService>();
        builder.Services.AddTransient<IUserService, UserService>();
        builder.Services.AddTransient<IHomePageService, HomePageService>();
        builder.Services.AddTransient<IBannerService, BannerService>();
        builder.Services.AddTransient<IUrlRecordService, UrlRecordService>();
        builder.Services.AddTransient<IPictureService, PictureService>();
        builder.Services.AddSingleton<HttpClientHelper>();
        builder.Services.AddTransient<UnauthorizedResponseHandler>();
        builder.Services.AddTransient<SlugRouteTransformer>();
        builder.Services.AddSingleton(new JsonSerializerOptions
        {
            PropertyNamingPolicy = null,
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        });


        var jwtSection = builder.Configuration.GetSection("Authorization");
        var jwtOptions = new AuthorizationOptions();
        jwtSection.Bind(jwtOptions);
        builder.Services.Configure<AuthorizationOptions>(jwtSection);


        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
        {
            options.LoginPath = "/account/login";
            options.LogoutPath = "/account/logout";
        });

        builder.Services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromSeconds(1);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });

        builder.Services.AddHttpContextAccessor();
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        //app.UseExceptionHandler("/Error");
        //app.UseStatusCodePagesWithReExecute("/Error/{0}");

        app.UseRouting();
        app.UseSession();

        app.UseAuthentication();
        app.UseAuthorization();

        //app.ConfigureCustomExceptionMiddleware();

        app.MapDynamicControllerRoute<SlugRouteTransformer>("{slug}", state: null);

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Install}/{action=Index}/{id?}");

        app.Run();
    }
}