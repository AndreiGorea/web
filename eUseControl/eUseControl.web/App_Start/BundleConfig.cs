using System.Web;
using System.Web.Optimization;
using System;

namespace eUserControl.web
{
     public class BundleConfig
     {
          public static void RegisterBundles(BundleCollection bundles)
          {
               // Home style
               bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
                    "~/Content/bootstrap.min.css"));

               bundles.Add(new StyleBundle("~/bundles/font-awesome").Include(
                    "~/Content/font-awesome.min.css"));

               bundles.Add(new StyleBundle("~/bundles/owl/carousel").Include(
                    "~/Content/owl.carousel.min.css"));

               bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                    "~/Content/style.css"));

               bundles.Add(new StyleBundle("~/bundles/elegant-icons").Include(
                    "~/Content/elegant-icons.css"));

               bundles.Add(new StyleBundle("~/bundles/nice-select").Include(
                    "~/Content/nice-select.css"));

               bundles.Add(new StyleBundle("~/bundles/jquery-ui").Include(
                    "~/Content/jquery-ui.min.css"));

               bundles.Add(new StyleBundle("~/bundles/slick").Include(
                    "~/Content/slicknav.min.css"));




               //Scripts

               bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                    "~/Scripts/bootstrap.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/mixitup/js").Include(
                    "~/Scripts/mixitup.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                    "~/Scripts/main.js"));

               bundles.Add(new ScriptBundle("~/bundles/owl-carousel/js").Include(
                    "~/Scripts/owl.carousel.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/jquery-ui/js").Include(
                    "~/Scripts/jquery-ui.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/jquery/nice-select/js").Include(
                    "~/Scripts/jquery.nice-select.min.js"));

               bundles.Add(new ScriptBundle("~/bundles/jqueryval/js").Include(
                    "~/Scripts/jquery.validate*"));

               bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                    "~/Scripts/jquery-{version}.js"));

               bundles.Add(new ScriptBundle("~/bundles/jquery/slicknav/js").Include(
                    "~/Scripts/jquery.slicknav.js"));

               bundles.Add(new ScriptBundle("~/bundles/popper-utils/js").Include(
                    "~/Scripts/popper-utils.js",
                    "~/Scripts/popper-utils.min.js",
                    "~/Scripts/popper.min.js"));

          }

     }
}
