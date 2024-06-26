using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Blazored.Toast;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Restaurant.Client;
using Restaurant.Client.wwwroot.Auth;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration.GetValue<string>("Hosting:BaseUrl")!) });

builder.Services.AddBlazoredSessionStorage();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredToast();
builder.Services.AddSweetAlert2();

// Habilitamos el contexto de seguridad de Blazor
builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationService>();
//builder.Services.AddScoped<ICarritoProxy, CarritoProxy>();
builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
