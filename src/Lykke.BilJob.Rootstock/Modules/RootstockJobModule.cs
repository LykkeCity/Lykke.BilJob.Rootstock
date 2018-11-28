using Autofac;
using JetBrains.Annotations;
using Lykke.BilJob.Rootstock.Settings;
using Lykke.Quintessence.Settings;
using Lykke.Quintessence.Utils;

namespace Lykke.BilJob.Rootstock.Modules
{
    [UsedImplicitly]
    public class RootstockJobModule : Module
    {
        private readonly AppSettings<RootstockJobSettings> _appSettings;

        public RootstockJobModule(
            AppSettings<RootstockJobSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            builder
                .RegisterRootstock(_appSettings.Job.IsMainNet);
        }
    }
}