using Microsoft.AspNetCore.Mvc;

namespace ProjectMVC.Areas.AdminArea.ViewComponents
{
    public class HeaderViewComponents:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
