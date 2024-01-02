using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Nop.Services.Plugins;

namespace Nop.Plugin.SocialMarket.Api
{
    public class SocialMarketApiPlugin : BasePlugin
    {
        public override async Task InstallAsync()
        {
            await base.InstallAsync();
        }

        public override async Task UninstallAsync()
        {
            await base.UninstallAsync();
        }
    }
}