using Auth0.AspNetCore.Authentication;
using MicroservicesIdentity.Web.Service;
using MicroservicesIdentity.Web.Service.IService;
using MicroservicesIdentity.Web.Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient<IEventService, EventService>();
builder.Services.AddHttpClient<ISessionService, SessionService>();
builder.Services.AddHttpClient<ISpeakerService, SpeakerService>();

builder.Services.AddAuth0WebAppAuthentication(options =>
{
    options.Domain = builder.Configuration["Auth0:Domain"];
    options.ClientId = builder.Configuration["Auth0:ClientId"];
});

SD.EventAPIBase = builder.Configuration["ServiceUrls:EventAPI"];
SD.SpeakerAPIBase = builder.Configuration["ServiceUrls:SpeakerAPI"];
SD.SessionAPIBase = builder.Configuration["ServiceUrls:SessionAPI"];

builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<IBaseService, BaseService>();
builder.Services.AddScoped<ISpeakerService, SpeakerService>();
builder.Services.AddScoped<ISessionService, SessionService>();


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

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

