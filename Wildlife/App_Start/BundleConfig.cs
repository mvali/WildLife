using System.Web;
using System.Web.Optimization;

namespace Wildlife
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Assets/Scripts/jquery.{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Assets/js/jquery-2.2.3.min.js",//nav
                "~/Assets/js/responsiveslides.min.js",//ok
                "~/Assets/js/scrolling-nav.js",//ok
                "~/Assets/js/counter.js",//ok
                "~/Assets/js/jquery.picEyes.js",//ok
                "~/Assets/js/move-top.js",
                "~/Assets/js/easing.js",
                "~/Assets/js/SmoothScroll.min.js",
                "~/Assets/js/blast.min.js",
                "~/Assets/js/bootstrap.js",
                "~/Assets/js/main.js"
                ));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Assets/js/jquery.validate*",
                "~/Assets/js/jquery.unobtrusive-ajax.min.js"
                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            //bundles.Add(new StyleBundle("~/bundles/css").IncludeDirectory("~/Assets/Css", "*.css"));
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Assets/Css/bootstrap.css",
                "~/Assets/Css/blast.min.css",
                "~/Assets/Css/portfolio.css",
                "~/Assets/Css/font-awesome.min.css",
                "~/Assets/Css/style.css"
                ));

        }
    }
}
