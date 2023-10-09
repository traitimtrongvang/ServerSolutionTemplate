using Application;
using IdentityService;
using PrimaryDatabase;
using RestfulApi;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

#region Drivens

builder.Services.AddPrimaryDatabaseServices(configuration);
builder.Services.AddIdentityServiceServices(configuration);

#endregion

#region Application

builder.Services.AddApplicationServices();

#endregion

#region Drivings

builder.Services.AddRestfulApiServices(configuration);

#endregion

var app = builder.Build();

app.UseRestfulApiConfigurations();

app.Run();