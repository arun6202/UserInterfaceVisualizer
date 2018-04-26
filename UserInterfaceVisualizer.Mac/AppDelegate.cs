using AppKit;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;
using XamarinFormsStarterKit.UserInterfaceVisualizer;
 using FFImageLoading.Forms.Mac;

namespace UserInterfaceVisualizer.Mac
{
	[Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        NSWindow _window;

        public AppDelegate()
        {
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

			var rect = new CoreGraphics.CGRect(2000, 2000, 2000, 2000);
			_window = new NSWindow(rect, style, NSBackingStore.Buffered, false)
			{
				Title = "Visualizer",
				TitleVisibility = NSWindowTitleVisibility.HiddenWhenActive
			};
		}

        public override NSWindow MainWindow
        {
            get { return _window; }
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            Forms.Init();
			CachedImageRenderer.Init(); 
            LoadApplication(new App());
            base.DidFinishLaunching(notification);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }


}
