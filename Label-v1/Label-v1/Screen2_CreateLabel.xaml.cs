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
        Label label = new Label();
        //Main Function
        public Screen2_CreateLabel()
        {
            this.InitializeComponent();
        }


        //Defualt Functions
        private void RowValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrRowColumn[0] = RowSlider.Value;
            }
            catch
            {

            }
        }

        private void ColumnValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

            try
            {
                label.ArrRowColumn[1] = ColumnSlider.Value;
            }
            catch
            {

            }
        }

        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                funcCreateTextbox();
                ++label.varAddButton;
                if (label.varAddButton > 0)
                {
                    MoreSettingsButton.IsEnabled = true;
                    SubButton.IsEnabled = true;
                }
                 funcCreateLabel();
            }
            catch
            {

            }
        }

        private void SubButtonClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                funcRemoveTextbox();
                label.varAddButton--;
                if (label.varAddButton == 0)
                {
                    MoreSettingsButton.IsEnabled = false;
                    SubButton.IsEnabled = false;
                }
                 funcCreateLabel();
            }
            catch
            {

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
        private void LabelNameTextBoxChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                label.ArrText[0] = Textbox0.Text;
                funcCreateLabel();
            }
            catch
            {

            }
        }


        private void MoreSettingsButtonClicked(object sender, RoutedEventArgs e)
        {
            CreateLabelSettingsScrollViewer.Visibility = Visibility.Collapsed;
            MoreSettingsScrollView.Visibility = Visibility.Visible;
        }

        //Custom Functions

        void funcClearLabel()
        {
            PreviewLabelGrid.Children.Clear();
        }

        void funcCreateTextbox()
        {
                var textbox = new TextBox();
                textbox.Name = "TextBox" + label.varAddButton;
                textbox.TextChanged += Textbox_TextChanged;
                textbox.HorizontalAlignment = HorizontalAlignment.Stretch;
                textbox.VerticalAlignment = VerticalAlignment.Stretch;
                textbox.PlaceholderText = "Enter Text Line " + (label.varAddButton + 1);
                textbox.Margin = new Thickness(10);
                textbox.Foreground = new SolidColorBrush(Colors.Black);
                textbox.TextAlignment = TextAlignment.Left;

            StackTextBox.Children.Add(textbox);
        }

        void funcRemoveTextbox()
        {
            StackTextBox.Children.RemoveAt(label.varAddButton - 1);
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textbox = (sender as TextBox);
            string temp = textbox.Name.Substring(textbox.Name.Length - 1);
            int TextboxNum = Convert.ToInt32(temp);

            label.ArrText[TextboxNum] = textbox.Text;

            funcCreateLabel();
        }
        
        void funcCreateLabel() {
            funcClearLabel();
            for(int i=0; i<label.varAddButton; i++)
            {   
                var textblock = new TextBlock();
                textblock.Width = label.ArrTextWidth[i];
                textblock.Height = label.ArrTextWidth[i];
                textblock.FontSize = label.ArrTextFont[i];
                textblock.FontFamily = new FontFamily(label.TextFont);
                textblock.Margin = new Thickness(label.ArrTextLeftMargin[i], label.ArrTextTopMargin[i], label.ArrTextRightMargin[i], label.ArrTextBottomMargin[i]);

                if (label.ArrTextHorizontalAlignMargin[i] == 0) textblock.HorizontalAlignment = HorizontalAlignment.Center;
                else if (label.ArrTextHorizontalAlignMargin[i] == 1) textblock.HorizontalAlignment = HorizontalAlignment.Left;
                else if (label.ArrTextHorizontalAlignMargin[i] == 2) textblock.HorizontalAlignment = HorizontalAlignment.Right;
                if (label.ArrTextVerticalAlignMargin[i] == 0) textblock.VerticalAlignment = VerticalAlignment.Center;
                else if (label.ArrTextVerticalAlignMargin[i] == 1) textblock.VerticalAlignment = VerticalAlignment.Top;
                else if (label.ArrTextVerticalAlignMargin[i] == 2) textblock.VerticalAlignment = VerticalAlignment.Bottom;

                PreviewRelativeLabel.Children.Add(textblock);
            }
            
        }
        void funcCreateMoreSettings()
        {
            var stack = new StackPanel();
            stack.Name = "MainStackMoreSettings" + label.varAddButton;
            stack.HorizontalAlignment = HorizontalAlignment.Stretch;
            stack.VerticalAlignment = VerticalAlignment.Stretch;
            PreviewRelativeLabel.Children.Add(stack);

            
            var stack1 = new StackPanel();
            stack1.Orientation = Orientation.Horizontal;
            
            var textblock1 = new TextBlock();
            textblock1.FontSize = 27;
            textblock1.Text = "Line 1";
            stack1.Children.Add(textblock1);

            var stack2 = new StackPanel();
            stack2.Orientation = Orientation.Horizontal;

            var textblock2 = new TextBlock();
            textblock2.FontSize = 15;
            textblock1.Text = "Width";
            stack2.Children.Add(textblock1);

            var slider1 = new Slider();

        }
        void funcRemoveMoreSettings()
        {
            PreviewRelativeLabel.Children.RemoveAt(label.varAddButton - 1);
        }

        void comboboxCheck(object sender , int number)
        {
            var comboBox = sender as ComboBox;
            if ((comboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Center") label.ArrTextAlignMargin[number] = 0;
            else if ((comboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Left") label.ArrTextAlignMargin[number] = 1;
            else if ((comboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Right") label.ArrTextAlignMargin[number] = 2;
        }

   }
}
