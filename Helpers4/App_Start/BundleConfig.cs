using System.Web;
using System.Web.Optimization;

namespace Helpers4
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // never ever ever ever point a bundle at a virtual URL that actually exists!!!!!!!!!!
            // see https://stackoverflow.com/questions/12240097/mvc4-bundling-does-not-work-when-optimizations-are-set-to-true

            bundles.Add(new StyleBundle("~/Content/Allcss").Include(
                      "~/Content/css/foundation.css",
                      "~/Content/css/app.css"));
        }
    }
}
