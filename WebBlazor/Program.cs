using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp;
using BlazorServices;
using Blazored.Toast; //Paquete de Blazored.Toast
using BlazorApp.Helpers; //JavascriptHelper

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Logging.SetMinimumLevel(LogLevel.Debug);

//Paquete de Blazored.Toast
builder.Services.AddBlazoredToast();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IWeatherForecastServices, WeatherForecastServices>();

builder.Services.AddScoped<IJavascriptHelper, JavascriptHelper>();

await builder.Build().RunAsync();
