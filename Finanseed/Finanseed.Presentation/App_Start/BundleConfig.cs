using System.Web;
using System.Web.Optimization;

namespace Finanseed.Presentation
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/popper.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/respond.js",
                "~/Scripts/bootstrap-datepicker.js",
                "~/Scripts/nouislider.min.js",
                "~/Scripts/bootstrap-switch.js",
                "~/Scripts/now-ui-kit.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/toastr")
                .Include("~/Scripts/toastr.min.js")
                );

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/now-ui-kit.css",
                      "~/Content/toastr.min.css",
                      "~/Content/site.css"));
        }
    }
}
