using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.MovieDetailViewComponents
{
    public class _MovieImageAndWatchTrailerComponetPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
