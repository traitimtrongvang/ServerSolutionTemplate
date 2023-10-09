using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrimaryDatabase.Settings;

namespace PrimaryDatabase;

public static class ServiceCollectionExt
{
    public static void AddPrimaryDatabaseServices(this IServiceCollection services, IConfiguration configuration)
    {
        #region Configurations

        services.Configure<PrimaryDbSetting>(configuration.GetSection(nameof(PrimaryDbSetting)));

        #endregion

        #region DbConfiguration

        var dbSetting = configuration.GetRequiredSection(nameof(PrimaryDbSetting)).Get<PrimaryDbSetting>()!;

        services.AddDbContext<PrimaryDbContext>(cfg => cfg.UseNpgsql(dbSetting.ConnectionStr));

        services.AddScoped<PrimaryDbContext>(sp => sp.GetRequiredService<PrimaryDbContext>());

        #endregion
    }
}