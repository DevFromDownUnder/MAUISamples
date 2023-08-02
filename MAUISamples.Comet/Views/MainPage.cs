namespace MAUISamples.Comet.Views
{
    public partial class MainPage : View
    {
        private int count = 0;
        private readonly State<string> countText = "Current count: 0";
        private readonly ISemanticScreenReader _screenReader;

        public MainPage(ISemanticScreenReader screenReader)
        {
            _screenReader = screenReader;
            Body = Build;
        }

        View Build() => new ScrollView()
        {
            new VStack(spacing: 25)
            {
                new Text(() => "Hello, World!").FontFamily(() => AppFont)
                                               .FontSize(32)
                                               .Color(() => AppColor),
                new Text(() => "Welcome to .NET Multi-platform App UI").FontFamily(() => AppFont)
                                                                       .FontSize(18)
                                                                       .Color(() => AppColor),
                new Text(countText).FontFamily(() => AppFont)
                                   .FontSize(18)
                                   .FontWeight(FontWeight.Bold)
                                   .Color(() => AppColor),
                new Button("Click me", IncrementCount).FontFamily(() => AppFont)
                                                 .FontSize(AppFontSize)
                                                 .Background(() => AppColor)
                                                 .Color(() => White)
                                                 .Padding(new Thickness(14, 10)),
                new Image(() => "dotnet_bot.png")
            }.Padding(30)
        };

        private void IncrementCount()
        {
            count++;
            countText.Value = $"Current count: {count}";
            _screenReader.Announce(countText.Value);
        }
    }
}
