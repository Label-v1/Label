using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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

        static double varRows = 1, varColumn = 1;
        static int varAddButton = 0;
        static string[] textArray = new string[8] { "Label Name", "Line 1", "Line 2", "Line 3", "Line 4", "Line 5", "Line 6" ,"Line 7"}; 
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
            funcCreateRows();
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
            funcCreateRows();
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
        private void LabelNameTextBoxChanged(object sender, TextChangedEventArgs e)
        {
            textArray[0] = Textbox0.Text;
            funcCreateRows();
        }

        private void Textbox1Changed(object sender, TextChangedEventArgs e)
        {
            textArray[1] = Textbox1.Text;
            funcCreateRows();
        }

        private void Textbox2Changed(object sender, TextChangedEventArgs e)
        {
            textArray[2] = Textbox2.Text;
            funcCreateRows();
        }

        private void Textbox3Changed(object sender, TextChangedEventArgs e)
        {
            textArray[3] = Textbox3.Text;
            funcCreateRows();
        }

        private void Textbox4Changed(object sender, TextChangedEventArgs e)
        {
            textArray[4] = Textbox4.Text;
            funcCreateRows();
        }

        private void Textbox5Changed(object sender, TextChangedEventArgs e)
        {
            textArray[5] = Textbox5.Text;
            funcCreateRows();
        }

        private void Textbox6Changed(object sender, TextChangedEventArgs e)
        {
            textArray[6] = Textbox6.Text;
            funcCreateRows();
        }

        private void Textbox7Changed(object sender, TextChangedEventArgs e)
        {
            textArray[7] = Textbox7.Text;
            funcCreateRows();
        }

        
        //Custom Functions

        private void MoreSettingsButton(object sender, RoutedEventArgs e)
        {
            CreateLabelSettingsScrollViewer.Visibility = Visibility.Collapsed;
            MoreSettingsScrollView.Visibility = Visibility.Visible;
        }

        private void MoreSettingsButtonSaved(object sender, RoutedEventArgs e)
        {
            MoreSettingsScrollView.Visibility = Visibility.Collapsed;
            CreateLabelSettingsScrollViewer.Visibility = Visibility.Visible;
        }

        private void FontSliderChanged1(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void FontSliderChanged2(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void FontSliderChanged3(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void FontSliderChanged4(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void FontSliderChanged5(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void FontSliderChanged6(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void FontSliderChanged7(object sender, RangeBaseValueChangedEventArgs e)
        {

        }
        void funcClearRows()
        {
            PreviewLabelGrid.Children.Clear();
            PreviewLabelGrid.RowDefinitions.Clear();
        }

        void funcCreateRows() {
            funcClearRows();
            for (int i = 0; i < varAddButton; i++)
            {
                RowDefinition r = new RowDefinition();
                PreviewLabelGrid.RowDefinitions.Add(r);
            }
            foreach(RowDefinition row in PreviewLabelGrid.RowDefinitions)
            {
                row.Height = new GridLength(1, GridUnitType.Star); row.Height = new GridLength(1, GridUnitType.Star);
            }
            for(int i = 0; i < PreviewLabelGrid.RowDefinitions.Count; i++)
            {
                var stack = new StackPanel();

                stack.Orientation = Orientation.Vertical;

                stack.Margin = new Thickness(0);
                stack.SetValue(Grid.RowProperty, i);
                stack.SetValue(Grid.ColumnProperty, 0);
                PreviewLabelGrid.Children.Add(stack);

                var textblck = new TextBlock();
                textblck.HorizontalAlignment = HorizontalAlignment.Stretch;
                textblck.VerticalAlignment = VerticalAlignment.Stretch;
                
                textblck.Text = textArray[i+1];
                textblck.Foreground = new SolidColorBrush(Colors.Black);
                stack.Children.Add(textblck);

            }
        }
    }
}
