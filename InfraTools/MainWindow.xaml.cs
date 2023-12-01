using System.Windows;

namespace InfraTools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Title = $"{AppInfo.AppInfo.AppTitle} Version {AppInfo.AppInfo.AppVersion}";
            
            /// Attempt to set the icon of the window from a resource svg file directly. Not working.
            //var imageTitle = new System.Windows.Controls.Image();
            //var uriSource = new System.Uri(@"../../Resources/BridgeIcon.svg", System.UriKind.Relative);
            //if (uriSource != null)
            //    if (uriSource.IsFile)
            //        imageTitle.Source = new System.Windows.Media.Imaging.BitmapImage(uriSource);
            //        Icon = imageTitle.Source;

            InitializeComponent();
        }
    }
}
