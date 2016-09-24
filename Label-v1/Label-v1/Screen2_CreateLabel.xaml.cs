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
                textbox.PlaceholderText = "Enter Text Line " + (label.varAddButton + 1);
                textbox.Margin = new Thickness(10);
                textbox.Foreground = new SolidColorBrush(Colors.Black);
                textbox.TextAlignment = TextAlignment.Left;
                textbox.FontSize = 15;
                textbox.FontFamily = new FontFamily("Arial");
            
            var button = new Button();
            button.Name = "Button" + label.varAddButton;
            button.FontFamily = new FontFamily("Segoe MDL2 Assets");
            button.Content = char.ConvertFromUtf32(0xE106);
            button.Margin = new Thickness(0,10,10,10);
            button.Foreground = new SolidColorBrush(Colors.White);
            button.Width = 32;
            button.Height = 32;

                label.ArrTextHorizontalAlignMargin.Insert(label.varAddButton, 0);
                label.ArrTextVerticalAlignMargin.Insert(label.varAddButton, 0);
                label.ArrTextLeftMargin.Insert(label.varAddButton,0);
                label.ArrTextRightMargin.Insert(label.varAddButton, 0);
                label.ArrTextTopMargin.Insert(label.varAddButton, 0);
                label.ArrTextBottomMargin.Insert(label.varAddButton, 0);
                label.ArrTextFont.Insert(label.varAddButton, 15);
                label.TextFont = "Arial";
                label.ArrText.Insert(label.varAddButton, "Text Line " + (label.varAddButton + 1));

            StackButton.Children.Add(button);

            StackTextBox.Children.Add(textbox);
        }

        void funcRemoveTextbox()
        {
            StackTextBox.Children.RemoveAt(label.varAddButton - 1);
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int TextboxNum;
                var textbox = (sender as TextBox);
                if (label.varAddButton >= 11)
                {
                    string temp = textbox.Name.Substring(textbox.Name.Length - 2);
                    TextboxNum = Convert.ToInt32(temp);
                }
                else
                {
                    string temp = textbox.Name.Substring(textbox.Name.Length - 1);
                    TextboxNum = Convert.ToInt32(temp);
                }


                label.ArrText[TextboxNum] = textbox.Text;

                funcCreateLabel();
            }
            catch
            {

            }
        }
        
        void funcCreateLabel() {
            funcClearLabel();
            for(int i=0; i<label.varAddButton; i++)
            {
                var textblock = new TextBlock();
                textblock.FontSize = label.ArrTextFont[i];
                textblock.FontFamily = new FontFamily(label.TextFont);
                textblock.Foreground = new SolidColorBrush(Colors.Black);
                textblock.Margin = new Thickness(label.ArrTextLeftMargin[i], label.ArrTextTopMargin[i], label.ArrTextRightMargin[i], label.ArrTextBottomMargin[i]);
                textblock.Text = label.ArrText[i];

                if (label.ArrTextHorizontalAlignMargin[i] == 0) textblock.HorizontalAlignment = HorizontalAlignment.Center;
                else if (label.ArrTextHorizontalAlignMargin[i] == 1) textblock.HorizontalAlignment = HorizontalAlignment.Left;
                else if (label.ArrTextHorizontalAlignMargin[i] == 2) textblock.HorizontalAlignment = HorizontalAlignment.Right;

                if (label.ArrTextVerticalAlignMargin[i] == 0) textblock.VerticalAlignment = VerticalAlignment.Center;
                else if (label.ArrTextVerticalAlignMargin[i] == 1) textblock.VerticalAlignment = VerticalAlignment.Top;
                else if (label.ArrTextVerticalAlignMargin[i] == 2) textblock.VerticalAlignment = VerticalAlignment.Bottom;
                
                PreviewLabelGrid.Children.Add(textblock);
                
            }
            
        }
        /*
        void comboboxCheck(object sender , int number)
        {
            var comboBox = sender as ComboBox;
            if ((comboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Center") label.ArrTextAlignMargin[number] = 0;
            else if ((comboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Left") label.ArrTextAlignMargin[number] = 1;
            else if ((comboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Right") label.ArrTextAlignMargin[number] = 2;
        }*/

   }
}
