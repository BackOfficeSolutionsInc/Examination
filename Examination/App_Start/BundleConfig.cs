using System.Web;
using System.Web.Optimization;
using Examination.Utilities;
using System.Collections.Generic;

namespace Examination {
	public class BundleConfig {

		private static Bundle UpdateMinification(Bundle scripts) {
			if (Config.DisableMinification()) {
				scripts.Transforms.Clear();
			}
			return scripts;
		}


		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles) {			
			Main(bundles);
            Menu(bundles);
			thankyou(bundles);
			BundleTable.EnableOptimizations = Config.OptimizationEnabled();

		}

		private static void Main(BundleCollection bundles) {

			bundles.Add(new StyleBundle("~/Content/style")
				.Include("~/Content/style/main.css"));
		}

        private static void Menu(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Content/style/menu")
                .Include("~/Content/style/menu.css"));
        }

		private static void thankyou(BundleCollection bundles) {

			bundles.Add(new StyleBundle("~/Content/style/thankyou")
				.Include("~/Content/style/thankyou.css"));
		}





		//private static void Main(BundleCollection bundles) {

		//	var list = new List<string>() {
		//		"~/Scripts/Main/time.js",
		//		"~/Scripts/Main/linq.js",
		//		"~/Scripts/Main/radial.js",
		//		"~/Scripts/Main/realtime.js",
		//		"~/Scripts/Main/modals.js",
		//		"~/Scripts/Main/datepickers.js",
		//		"~/Scripts/Main/support.js",
		//		"~/Scripts/Main/backwardcompatability.js",
		//		"~/Scripts/Main/ajaxintercepters.js",
		//		"~/Scripts/Main/datatable.js",
		//		"~/Scripts/Main/tours.js",
		//		"~/Scripts/Main/alerts.js",
		//		"~/Scripts/Main/clickableclass.js",
		//		"~/Scripts/Main/profilepicture.js",
		//		"~/Scripts/Main/libraries.js",
		//		"~/Scripts/Main/chart.js",
		//		"~/Scripts/Main/notifications.js",
		//	};


		//	//Only intercept logs if not local...
		//	if (Config.GetEnv() != Env.local_mysql)
		//		list.Add("~/Scripts/Main/log-helper.js");

		//	list.AddRange(new[] {
		//              /*"~/Scripts/jquery.signalR-{version}.js",Was deleted*/
		//              "~/Scripts/jquery/jquery.tablesorter.js",
		//		"~/Scripts/Main/finally.js",
		//		"~/Scripts/Main/intercom.min.js",
		//		"~/Scripts/L10/jquery-ui.color.js",
		//		"~/Scripts/jquery/jquery.tabbable.js",
		//		"~/Scripts/components/milestones.js",
		//		"~/Scripts/Main/keyboard.js",
		//		"~/Scripts/Main/tooltips.js",
		//		"~/Scripts/Main/beta.js"
		//	});

		//	bundles.Add(UpdateMinification(new ScriptBundle("~/bundles/main").Include(list.ToArray())));

		//}








		//private static void Manage(BundleCollection bundles) {
		//	bundles.Add(UpdateMinification(new ScriptBundle("~/bundles/Manage").Include(
		//		"~/Scripts/jquery/jquery.tablesorter.js",
		//		"~/Scripts/jquery/jquery.filtertable.min.js"
		//	)));

		//	bundles.Add(new StyleBundle("~/Content/ManageCSS")
		//		.Include("~/Content/Manage/Manage.css"));
		//}

	}
	}
