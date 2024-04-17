using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Providers;
using System.BussinessRules;
using App.API.Injections;


#region Builder
var builder = WebApplication.CreateBuilder(args);




    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddDbContext<EntityContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("App.API")));


    #region Injections
        Injections.InjectProviders(builder);
        Injections.InjectRules(builder);
    #endregion







var app = builder.Build();
#endregion

#region Culture
var supportedCultures = new List<CultureInfo> { new CultureInfo("pt-BR") };
var requestLocalizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("pt-BR"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
};
#endregion

#region App
app.UseRequestLocalization(requestLocalizationOptions);
app.UseDefaultFiles();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapFallbackToFile("/index.html");

app.UseCors(Cors => Cors.AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin());

app.Run();

#endregion
