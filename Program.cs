var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//mvc
//rest api
//razor pages

app.MapGet("/", () => "Hello World!");
app.MapGet("/abc", () => "Deneme");

app.Run();
