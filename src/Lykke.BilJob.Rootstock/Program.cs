using System.Threading.Tasks;
using Lykke.BilJob.Rootstock.Settings;
using Lykke.Quintessence;

namespace Lykke.BilJob.Rootstock
{
    internal static class Program
    {
        #if DEBUG
        
        private const bool IsDebug = true;
        
        #else

        private const bool IsDebug = false;

        #endif
        
        private static Task Main()
        {
            return JobStarter
                .StartAsync<Startup, RootstockJobSettings>(IsDebug);
        }
    }
}