using Microsoft.UI.Xaml.Controls;

namespace winui_example02
{
    public sealed partial class About : Page
    {
        public About()
        {
            InitializeComponent();
        }

        public static async void Dialog(MainWindow mainWindow)
        {
            ContentDialog dialog = new();
            dialog.XamlRoot = mainWindow.Content.XamlRoot;
            dialog.Title = "AppTitle";
            dialog.PrimaryButtonText = "OK";
            dialog.DefaultButton = ContentDialogButton.Primary;
            dialog.Content = new About();
            await dialog.ShowAsync();
        }
    }
}
