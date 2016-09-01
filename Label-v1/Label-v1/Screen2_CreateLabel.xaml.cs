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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Label_v1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Screen2_CreateLabel : Page
    {
        //Variables

        double varRows = 1, varColumn = 1;
        int varAddButton = 0;

        //Main Function
        public Screen2_CreateLabel()
        {
            this.InitializeComponent();
        }


        //Defualt Functions
        private void RowValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            varRows = RowSlider.Value; 
        }

        private void ColumnValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            varColumn = ColumnSlider.Value;
        }

        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            if (varAddButton == 0) {
                SubButton.IsEnabled = true;
                varAddButton++;
                Textbox1.Visibility = Visibility.Visible;
            }
            else if (varAddButton == 1)
            {
                varAddButton++;
                Textbox2.Visibility = Visibility.Visible;
            }
            else if (varAddButton == 2)
            {
                varAddButton++;
                Textbox3.Visibility = Visibility.Visible;
            }
            else if (varAddButton == 3)
            {
                varAddButton++;
                Textbox4.Visibility = Visibility.Visible;
            }
            else if (varAddButton == 4)
            {
                varAddButton++;
                Textbox5.Visibility = Visibility.Visible;
            }
            else if (varAddButton == 5)
            {
                varAddButton++;
                Textbox6.Visibility = Visibility.Visible;
            }
            else if (varAddButton == 6)
            {
                varAddButton++;
                AddButton.IsEnabled = false;
                Textbox7.Visibility = Visibility.Visible;
            }
        }

        private void SubButtonClicked(object sender, RoutedEventArgs e)
        {
            if (varAddButton == 7) {
                AddButton.IsEnabled = true;
                varAddButton--;
                Textbox7.Visibility = Visibility.Collapsed;
            }
            else if (varAddButton == 6) {
                varAddButton--;
                Textbox6.Visibility = Visibility.Collapsed;
            }
            else if (varAddButton == 5)
            {
                varAddButton--;
                Textbox5.Visibility = Visibility.Collapsed;
            }
            else if (varAddButton == 4)
            {
                varAddButton--;
                Textbox4.Visibility = Visibility.Collapsed;
            }
            else if (varAddButton == 3)
            {
                varAddButton--;
                Textbox3.Visibility = Visibility.Collapsed;
            }
            else if (varAddButton == 2)
            {
                varAddButton--;
                Textbox2.Visibility = Visibility.Collapsed;
            }
            else if (varAddButton == 1)
            {
                SubButton.IsEnabled = false;
                varAddButton--;
                Textbox1.Visibility = Visibility.Collapsed;
            }
            else if (varAddButton == 0)
            {
                SubButton.IsEnabled = false;
            }
        }

        private void closePopup(object sender, RoutedEventArgs e)
        {

        }

        private void BackButtonClicked(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack) {
                Frame.GoBack();
            }
        }

        //Custom Functions
    }
}
