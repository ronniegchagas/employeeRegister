using System.Web;
using System.Web.Optimization;

namespace employeeRegister
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/assets/jquery").Include(
            //            "~/assets/js/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/assets/jqueryval").Include(
            //            "~/assets/js/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/assets/css").Include(
                      //"~/Content/bootstrap.css",
                      "~/assets/css/main.css"));
        }
    }
}
