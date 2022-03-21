using Squirrel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCard.Settings
{
    public class Update
    {
        public static async Task<bool> CheckForUpdates()
        {
            await Task.Delay(0);
            using (var mgr = await UpdateManager .GitHubUpdateManager("https://github.com/artygreis/AreaCard"))
            {
                var result = await mgr.UpdateApp();
                return result != null;
            }
        }
    }
}
