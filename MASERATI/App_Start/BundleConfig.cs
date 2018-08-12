using System.Web;
using System.Web.Optimization;

namespace MASERATI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css"));

            bundles.Add(new StyleBundle("~/Scripts/js").Include(
                     "~/Scripts/jquery-3.3.1.min.js",
                     "~/Scripts/script.js"));
        }
    }
}
