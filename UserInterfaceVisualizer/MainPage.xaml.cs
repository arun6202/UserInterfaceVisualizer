using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsStarterKit.UserInterfaceBuilder;

namespace XamarinFormsStarterKit.UserInterfaceVisualizer
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
             
			ComponentBuilder.LoadAllComponents(Content);
		}

		protected override void  OnAppearing()
		{
			base.OnAppearing();

			//iPhoneX.Source = "/Users/arunbalakrishnan/UserInterfaceTestRunner/UserInterfaceTestRunner/Screenshots/ios/iPhone X.png";
			//iPhone8.Source = "/Users/arunbalakrishnan/UserInterfaceTestRunner/UserInterfaceTestRunner/Screenshots/ios/iPhone 8.png";
			//iPhone8p.Source ="/Users/arunbalakrishnan/UserInterfaceTestRunner/UserInterfaceTestRunner/Screenshots/ios/iPhone 8 Plus.png";
			//iPhoneSE.Source = "/Users/arunbalakrishnan/UserInterfaceTestRunner/UserInterfaceTestRunner/Screenshots/ios/iPhone SE.png";

			//android720_1280_5.Source ="/Users/arunbalakrishnan/UserInterfaceTestRunner/UserInterfaceTestRunner/Screenshots/ios/iPhone X.png";
			//android1080_1920_5_2.Source ="/Users/arunbalakrishnan/UserInterfaceTestRunner/UserInterfaceTestRunner/Screenshots/ios/iPhone X.png";
			//android1440_2560_5_8.Source= "/Users/arunbalakrishnan/UserInterfaceTestRunner/UserInterfaceTestRunner/Screenshots/ios/iPhone X.png";
			//android1440_2560_6_2.Source ="/Users/arunbalakrishnan/UserInterfaceTestRunner/UserInterfaceTestRunner/Screenshots/ios/iPhone X.png";

             
		}
        
	}
}
