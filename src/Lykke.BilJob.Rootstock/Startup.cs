using JetBrains.Annotations;
using Lykke.BilJob.Rootstock.Modules;
using Lykke.BilJob.Rootstock.Settings;
using Lykke.Quintessence;
using Lykke.Sdk;

namespace Lykke.BilJob.Rootstock
{
    [UsedImplicitly]
    public class Startup : JobStartupBase<RootstockJobSettings>
    {
        protected override string IntegrationName
            => "Rootstock";

        protected override void RegisterAdditionalModules(
            IModuleRegistration modules)
        {
            modules.RegisterModule<RootstockJobModule>();
            
            base.RegisterAdditionalModules(modules);
        }
    }
}