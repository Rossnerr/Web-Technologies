using System.Web;
using System.Web.Optimization;

namespace eUseControl
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Home style
            bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                "~/Content/file.css", new CssRewriteUrlTransform()));

            //Bootstrap style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

            //Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                "~/Scripts/bootstrap.min.js"));

            //jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                "~/Scripts/jquery-3.3.1.min.js"));
        }
    }
}
