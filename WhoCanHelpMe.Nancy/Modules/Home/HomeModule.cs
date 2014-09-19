 namespace WhoCanHelpMe.Nancy.Modules.Home
{
    using global::Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            this.Get["/"] = GetHome;
        }

        private object GetHome(dynamic arg)
        {
            return this.View["Home"];
        }
    }
}