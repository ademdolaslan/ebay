using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ebay.App_Start
{
    public class BundleConfig
    {
        public static void BundleEt(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery-3.4.1.min.js",                
                "~/Scripts/custom.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery.validate.unobtrusive.min.js",
                "~/Scripts/bootstrap.min.js",                
                "~/Scripts/popper.min.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js",
                "~/Scripts/DataTables/jquery.dataTables.min.js",
                "~/Scripts/DataTables/dataTables.bootstrap4.min.js",
                "~/Scripts/DataTables/dataTables.bootstrap4.js"
                
           ));
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/site.css",
                "~/Content/all.css",
                
                "~/Content/DataTables/css/dataTables.bootstrap.min.css"
                ));
        }
    }
}