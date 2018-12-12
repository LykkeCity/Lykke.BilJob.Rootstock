using Autofac;
using JetBrains.Annotations;
using Lykke.BilJob.Rootstock.Settings;
using Lykke.Quintessence.DependencyInjection;
using Lykke.Quintessence.Settings;
using Lykke.SettingsReader;

namespace Lykke.BilJob.Rootstock.Modules
{
    [UsedImplicitly]
    public class RootstockJobModule : Module
    {
        private readonly IReloadingManager<AppSettings<RootstockJobSettings>> _appSettings;

        public RootstockJobModule(
            IReloadingManager<AppSettings<RootstockJobSettings>> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            builder
                .UseRootstock
                (
                    _appSettings.ConnectionString(x => x.Job.Db.DataConnString),
                    _appSettings.Nested(x => x.Job.ConfirmationLevel),
                    _appSettings.ConnectionString(x => x.Job.GasPriceRange),
                    _appSettings.CurrentValue.Job.IsMainNet
                );
        }
    }
}