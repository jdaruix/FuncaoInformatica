using System.Web;
using System.Web.Optimization;

namespace WebAtividadeEntrevista
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                                   "~/Scripts/jquery.validate.js",
                                   "~/Scripts/jquery.validate.unobtrusive.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/jtable").Include(
                      "~/Scripts/jtable/jquery.jtable.min.js",
                      "~/Scripts/jtable/localization/jquery.jtable.pt-BR.js"));

            bundles.Add(new ScriptBundle("~/bundles/clientes").Include(
                      "~/Scripts/Clientes/FI.Clientes.js"));

            bundles.Add(new ScriptBundle("~/bundles/cliente-validator").Include(
                                  "~/Scripts/Clientes/FI.Clientes.Validate.js"));

            bundles.Add(new ScriptBundle("~/bundles/listClientes").Include(
                      "~/Scripts/Clientes/FI.ListClientes.js"));

            bundles.Add(new ScriptBundle("~/bundles/altClientes").Include(
                      "~/Scripts/Clientes/FI.AltClientes.js"));

            bundles.Add(new ScriptBundle("~/bundles/beneficiarios").Include(
                      "~/Scripts/Clientes/FI.Beneficiarios.js"));

            bundles.Add(new ScriptBundle("~/bundles/beneficiarios-validator").Include(
                                  "~/Scripts/Clientes/FI.Beneficiarios.Validate.js"));

            bundles.Add(new ScriptBundle("~/bundles/listbeneficiarios").Include(
                      "~/Scripts/Clientes/FI.ListBeneficiarios.js"));

            bundles.Add(new ScriptBundle("~/bundles/altbeneficiarios").Include(
                      "~/Scripts/Clientes/FI.AltBeneficiarios.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/jtable").Include(
                      "~/Scripts/jtable/themes/metro/darkgray/jtable.css"));

        }
    }
}
