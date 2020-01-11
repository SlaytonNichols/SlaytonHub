using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SlaytonHub.Model;

namespace SlaytonHub.ViewComponents
{
    public class InfoBoxViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string icon, string backgroundBox, string backgroundIcon, string text, string number, int? progressValue, string progressDescription)
        {
            return await Task.Run(() => View(new InfoBoxModel { Icon = icon, BackgroundBox = backgroundBox, BackgroundIcon = backgroundIcon, Text = text, Number = number, ProgressValue = progressValue, ProgressDescription = progressDescription }));
        }
    }
}
