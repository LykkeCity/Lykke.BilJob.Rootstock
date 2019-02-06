using JetBrains.Annotations;
using Lykke.Quintessence.Settings;

namespace Lykke.BilJob.Rootstock.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class RootstockJobSettings : JobSettings
    {
        public bool IsMainNet { get; set; }
    }
}