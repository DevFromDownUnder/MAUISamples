namespace MAUISamples.Comet
{
    public partial class App : CometApp
    {
        public App(IServiceProvider services) => Body = services.GetRequiredService<MainPage>;

        #region AppDefaults
        public static Color AppColor => Color.FromArgb("#512BD4");

        public static string AppFont => "OpenSansRegular";

        public static double AppFontSize => 14d;
        #endregion
    }
}
