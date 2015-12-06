using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;
using System.Web.UI;

namespace ClientDev.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            //Bundle jquery = new ScriptBundle("~/bundle/jquery")
            //                    .Include("~/Scripts/jquery-{version}.js");
            //Bundle jqueryui = new ScriptBundle("~/bundle/jqueryui")
            //                    .Include("~/Scripts/jquery-{version}.js",
            //                             "~/Scripts/jquery-ui-{version}.js");

            //Bundle jquery = new CdnScriptBundle("~/bundle/jquery")
            //                .CdnInclude("~/Scripts/jquery-{version}.js","http://ajax.aspnetcdn.com/ajax/jQuery/jquery-{version}.min.js");

            //last working bundle for jquery
           Bundle jquery = new ScriptBundle("~/bundle/jquery");
                  jquery.CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.2.min.js";
                  jquery.Include("~/Scripts/jquery-{version}.js");

            Bundle jqueryui = new ScriptBundle("~/bundle/jqueryui");
                   jqueryui.CdnPath = "http://ajax.aspnetcdn.com/ajax/jquery.ui/1.10.2/jquery-ui.min.js";
                   jqueryui.Include("~/Scripts/jquery-ui-{version}.js");


            Bundle basicStyles = new StyleBundle("~/bundle/basicCSS")
                                .Include("~/MainStyles.css", "~/ErrorStyles.css");

            //Bundle jqueryUIStyles = new StyleBundle("~/bundle/jqueryUICSS")
            //                    .IncludeDirectory("~/Content/themes/base", "*.css");

            Bundle jqueryUIStyles = new StyleBundle("~/Content/themes/base/jqueryUICSS")
                                .IncludeDirectory("~/Content/themes/base", "*.css");


            bundles.UseCdn = true;

            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", 
                            new ScriptResourceDefinition { Path = "~/Scripts/jquery-1.8.2.js" });

            bundles.Add(jquery);
            bundles.Add(jqueryui);
            bundles.Add(basicStyles);
            bundles.Add(jqueryUIStyles);
        }
    }
}
