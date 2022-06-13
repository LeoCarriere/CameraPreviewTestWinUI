using Microsoft.UI.Xaml;
using CommunityToolkit.WinUI.Helpers;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App11 {
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window {
        public MainWindow() {
            this.InitializeComponent();
        }

        
        private async void myButton_Click( object sender , RoutedEventArgs e ) {
            myButton.Content = "Clicked";
            await CameraPreviewControl.StartAsync();
            CameraPreviewControl.CameraHelper.FrameArrived += CameraPreviewControl_FrameArrived;


        }

        private void CameraPreviewControl_FrameArrived(object sender, FrameEventArgs e)
        {
             var videoFrame = e.VideoFrame;
             var softwareBitmap = videoFrame.SoftwareBitmap;
        }
    }
}
 