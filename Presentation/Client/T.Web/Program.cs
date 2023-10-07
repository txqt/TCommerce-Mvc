﻿using Microsoft.AspNetCore.Authentication.Cookies;
using System.Text.Json;
using T.Library.Model.Interface;
using T.Library.Model.JwtToken;
using T.Web.Common;
using T.Web.Services.AccountService;
using T.Web.Services.CategoryService;
using T.Web.Services.Database;
using T.Web.Services.HomePageServices;
using T.Web.Services.PrepareModel;
using T.Web.Services.PrepareModelServices;
using T.Web.Services.ProductService;
using T.Web.Services.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<JwtHandler>();
builder.Services.AddHttpClient("", sp =>
{
    sp.BaseAddress = new Uri(builder.Configuration.GetSection("Url:ApiUrl").Value);
})
    .AddHttpMessageHandler<JwtHandler>()
    .AddHttpMessageHandler<UnauthorizedResponseHandler>();

builder.Services.AddTransient<IDatabaseControl, DatabaseControl>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddTransient<IAccountService, AccountService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IProductAttributeService, ProductAttributeService>();
//builder.Services.AddTransient<IProductAttributeMappingService, ProductAttributeMappingService>();
//builder.Services.AddTransient<IProductAttributeValueService, ProductAttributeValueService>();
builder.Services.AddTransient<IProductModelService, ProductModelService>();
builder.Services.AddTransient<IUserModelService, UserModelService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IProductCategoryService, ProductCategoryService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IHomePageService, HomePageService>();
builder.Services.AddTransient<UnauthorizedResponseHandler>();
//builder.Services.AddTransient<ISliderItemService, SliderItemService>();
builder.Services.AddSingleton<JsonSerializerOptions>(new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    IgnoreNullValues = true
});


var jwtSection = builder.Configuration.GetSection("Authorization");
var jwtOptions = new JwtOptions();
jwtSection.Bind(jwtOptions);
builder.Services.Configure<JwtOptions>(jwtSection);


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = "/account/login";
    options.LogoutPath = "/account/logout";
});

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(jwtOptions.AccessTokenExpirationInHours);
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

app.UseExceptionHandler("/Error");
app.UseStatusCodePagesWithReExecute("/Error/{0}");

app.UseRouting();
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

//app.ConfigureCustomExceptionMiddleware();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
