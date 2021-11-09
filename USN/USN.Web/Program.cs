using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebSockets;
using USN.Web.Middlewares;

var builder = WebApplication.CreateBuilder(args);

#region Services

builder.Services.AddWebSockets(x =>
{
    x.KeepAliveInterval = TimeSpan.FromSeconds(30);
});

builder.Services.AddApiVersioning(x =>
{
    x.AssumeDefaultVersionWhenUnspecified = true;
    x.DefaultApiVersion = new ApiVersion(1, 0);
    x.ReportApiVersions = true;
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "USN.Web", Version = "v1" });
});

#endregion

var app = builder.Build();

#region Config

if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("ci"))
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "USN.Web v1"));
}
app.UseMiddleware<GlobalErrorHandlerMiddleware>();
app.UseMiddleware<AccessTokenMiddleware>();

app.UseWebSockets();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseApiVersioning();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

#endregion

app.Run();
