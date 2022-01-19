using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SearchApp;
using SearchApp.Client;
using Refit;
using SearchApp.Services;
using SearchApp.Handler;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<AuthenticatedHttpClientHandler>();
builder.Services.AddScoped<IVideoSearch, VideoSearch>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddRefitClient<ISearchClient>(provider => new RefitSettings() { ContentSerializer = new NewtonsoftJsonContentSerializer() })
   .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://ee.iva-api.com/"))
   .AddHttpMessageHandler<AuthenticatedHttpClientHandler>();

await builder.Build().RunAsync();
