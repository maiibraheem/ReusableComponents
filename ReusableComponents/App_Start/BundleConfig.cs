using System.Web;
using System.Web.Optimization;

namespace ReusableComponents
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/ApplyToJob").IncludeDirectory("~/Scripts/Controllers", "*.js")
                        .Include("~/Scripts/ApplyToJob.js"));
        }
    }
}
