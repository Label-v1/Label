using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Label_v1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextileButtonClicked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Screen2_CreateLabel));
        }

        private void FoodButtonClicked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Screen2_CreateLabel));
        }

        private void FootwearButtonClicked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Screen2_CreateLabel));
        }

        private void ExamButtonClicked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Screen2_CreateLabel));
        }
    }
}
