namespace AzadiSoft.UserManager.WebUI.DependencyResolution
{
    public static class DI
    {
        public static T Resolve<T>()
        {
            var container = IoC.Initialize();

            return container.GetInstance<T>();
        }
    }
}