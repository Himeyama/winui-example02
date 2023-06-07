namespace winui_example02
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);
        }

        void ClickExit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        void ClickAbout(object sender, RoutedEventArgs e)
        {
            About.Dialog(this);
        }
    }
}
