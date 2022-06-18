using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using GitHubPagesTest;
using GitHubPagesTest.Services.Contract;
using GitHubPagesTest.Services.Implementation;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ILocalStorageService, LocalStorageService>(); 
builder.Services.AddScoped<IFirebaseDbService, FirebaseDbService>(); 

await builder.Build().RunAsync();
