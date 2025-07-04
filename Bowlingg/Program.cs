using System.Net;
using Bowlingg.Components;
using Microsoft.EntityFrameworkCore;
using Database;




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BowlingContext>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
using (var ServiceScope = app.Services.CreateScope())
{
    var context = ServiceScope.ServiceProvider.GetRequiredService<BowlingContext>();
    context.Database.Migrate();
}

app.Run();