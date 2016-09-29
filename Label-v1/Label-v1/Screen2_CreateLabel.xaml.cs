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
        int selectedIndex;
        string[] allFonts = Microsoft.Graphics.Canvas.Text.CanvasTextFormat.GetSystemFontFamilies();
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


            foreach (StackPanel x in PreviewLabelGrid.Children)
            {
                x.BorderThickness = new Thickness(1);
                x.BorderBrush = new SolidColorBrush(Colors.DarkGray);
            }
        }
        int NotToRunAtStartup = 8;

        private void MoveLeftSliderChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if(NotToRunAtStartup > 0)
            {
               --NotToRunAtStartup;
                return;
            }
        }

        private void MoveBottomSliderChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (NotToRunAtStartup > 0)
            {
                --NotToRunAtStartup;
                return;
            }
        }

        private void MoveUpSliderChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (NotToRunAtStartup > 0)
            {
                --NotToRunAtStartup;
                return;
            }
        }

        private void MoveRightSLiderChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (NotToRunAtStartup > 0)
            {
                --NotToRunAtStartup;
                return;
            }
        }

        private void SliderFontSizeChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (NotToRunAtStartup > 0)
            {
                --NotToRunAtStartup;
                return;
            }
        }
        private void XAlignmentChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NotToRunAtStartup > 0)
            {
                --NotToRunAtStartup;
                return;
            }
            var combobox = sender as ComboBox;
            if ((combobox.SelectedItem as ComboBoxItem).Content.ToString() == "Center") label.ArrTextHorizontalAlignMargin[selectedIndex] = 0;
            else if ((combobox.SelectedItem as ComboBoxItem).Content.ToString() == "Left") label.ArrTextHorizontalAlignMargin[selectedIndex] = 1;
            else if ((combobox.SelectedItem as ComboBoxItem).Content.ToString() == "Right") label.ArrTextHorizontalAlignMargin[selectedIndex] = 2;

            funcCreateLabel();
        }

        private void YAlignmentChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NotToRunAtStartup > 0)
            {
                --NotToRunAtStartup;
                return;
            }
        }


        private void ComboboxFontsChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NotToRunAtStartup > 0)
            {
                --NotToRunAtStartup;
                return;
            }
        }


        private void MoreSettingsOkClicked(object sender, RoutedEventArgs e)
        {
            CreateLabelSettingsScrollViewer.Visibility = Visibility.Visible;
            MoreSettingsScrollView.Visibility = Visibility.Collapsed;


            foreach (StackPanel x in PreviewLabelGrid.Children)
            {
                x.BorderThickness = new Thickness(0);
                x.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
            XAlignment.IsEnabled = false;
            YAlignment.IsEnabled = false;
            MoveUpSlider.IsEnabled = false;
            MoveLeftSlider.IsEnabled = false;
            MoveRightSlider.IsEnabled = false;
            MoveBottomSlider.IsEnabled = false;
            SliderFontSize.IsEnabled = false;
            ComboboxFonts.IsEnabled = false;

            StatusTextBlock.Text = "Select a Text Block";
            StackStatusTextBlock.BorderThickness = new Thickness(0);
            StackStatusTextBlock.BorderBrush = new SolidColorBrush(Colors.Transparent);
        }

        //Custom Functions

        void funcClearLabel()
        {
            PreviewLabelGrid.Children.Clear();
        }

        void funcCreateTextbox()
        {
                var textbox = new TextBox();
                textbox.Name = label.varAddButton.ToString();
                textbox.TextChanged += Textbox_TextChanged;
                textbox.PlaceholderText = "Enter Text Line " + (label.varAddButton + 1);
                textbox.Margin = new Thickness(10);
                textbox.Foreground = new SolidColorBrush(Colors.Black);
                textbox.TextAlignment = TextAlignment.Left;
                textbox.FontSize = 15;
                textbox.FontFamily = new FontFamily("Arial");
            
            var button = new Button();
            button.Name =  label.varAddButton.ToString();
            button.FontFamily = new FontFamily("Segoe MDL2 Assets");
            button.Content = char.ConvertFromUtf32(0xE106);
            button.Margin = new Thickness(0,10,10,10);
            button.Foreground = new SolidColorBrush(Colors.White);
            button.Click += Button_Click;
            button.Width = 32;
            button.Height = 32;

                label.ArrTextHorizontalAlignMargin.Insert(label.varAddButton, 0);
                label.ArrTextVerticalAlignMargin.Insert(label.varAddButton, 0);
                label.ArrTextLeftMargin.Insert(label.varAddButton,0);
                label.ArrTextRightMargin.Insert(label.varAddButton, 0);
                label.ArrTextTopMargin.Insert(label.varAddButton, 0);
                label.ArrTextBottomMargin.Insert(label.varAddButton, 0);
                label.ArrTextFont.Insert(label.varAddButton, 15);
                label.ArrTextFontFamily.Insert(label.varAddButton,"Arial");
                label.ArrText.Insert(label.varAddButton, "Text Line " + (label.varAddButton + 1));

            StackButton.Children.Add(button);

            StackTextBox.Children.Add(textbox);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            int num = Convert.ToInt32(button.Name);
            StackButton.Children.RemoveAt(num);
            StackTextBox.Children.RemoveAt(num);

            label.ArrText.RemoveAt(num);
            label.ArrTextHorizontalAlignMargin.RemoveAt(num);
            label.ArrTextVerticalAlignMargin.RemoveAt(num);
            label.ArrTextLeftMargin.RemoveAt(num);
            label.ArrTextRightMargin.RemoveAt(num);
            label.ArrTextTopMargin.RemoveAt(num);
            label.ArrTextBottomMargin.RemoveAt(num);
            label.ArrTextFontFamily.RemoveAt(num);
            label.ArrTextFont.RemoveAt(num);

            label.varAddButton--;

            for (int i = 0; i< StackTextBox.Children.Count; i++)
            {
                TextBox textbox = StackTextBox.Children.ElementAt(i) as TextBox;
                textbox.Name = i.ToString();
                textbox.PlaceholderText = "Enter Text Line " + (i+1);
                if(label.ArrText[i].Contains("Text Line ")){
                    label.ArrText[i] = "Text Line " + (i + 1);
                }

                Button button1 = StackButton.Children.ElementAt(i) as Button;
                button1.Name = i.ToString();

            }
            funcCreateLabel();
        }

        void funcRemoveTextbox()
        {
            StackTextBox.Children.RemoveAt(label.varAddButton - 1);
            StackButton.Children.RemoveAt(label.varAddButton - 1);
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var textbox = (sender as TextBox);
                label.ArrText[Convert.ToInt32(textbox.Name)] = textbox.Text;
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
                var stack = new StackPanel();
                stack.Margin = new Thickness(label.ArrTextLeftMargin[i], label.ArrTextTopMargin[i], label.ArrTextRightMargin[i], label.ArrTextBottomMargin[i]);

                var textblock = new TextBlock();
                textblock.Name = i.ToString();
                textblock.FontSize = label.ArrTextFont[i];
                textblock.FontFamily = new FontFamily(label.ArrTextFontFamily[i]);
                textblock.Foreground = new SolidColorBrush(Colors.Black);
                textblock.Text = label.ArrText[i];
                textblock.Tapped += Textblock_Tapped;

                if (label.ArrTextHorizontalAlignMargin[i] == 0) stack.HorizontalAlignment = HorizontalAlignment.Center;
                else if (label.ArrTextHorizontalAlignMargin[i] == 1) stack.HorizontalAlignment = HorizontalAlignment.Left;
                else if (label.ArrTextHorizontalAlignMargin[i] == 2) stack.HorizontalAlignment = HorizontalAlignment.Right;

                if (label.ArrTextVerticalAlignMargin[i] == 0) stack.VerticalAlignment = VerticalAlignment.Center;
                else if (label.ArrTextVerticalAlignMargin[i] == 1) stack.VerticalAlignment = VerticalAlignment.Top;
                else if (label.ArrTextVerticalAlignMargin[i] == 2) stack.VerticalAlignment = VerticalAlignment.Bottom;

                stack.Children.Add(textblock);

                PreviewLabelGrid.Children.Add(stack);
                
            }
            
        }

        private void Textblock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                var textblock = sender as TextBlock;
                selectedIndex = Convert.ToInt32(textblock.Name);

                StatusTextBlock.Text = textblock.Text;
                StackStatusTextBlock.BorderThickness = new Thickness(2);
                StackStatusTextBlock.BorderBrush = new SolidColorBrush(Colors.Wheat);

                XAlignment.IsEnabled = true;
                YAlignment.IsEnabled = true;
                MoveUpSlider.IsEnabled = true;
                MoveLeftSlider.IsEnabled = true;
                MoveRightSlider.IsEnabled = true;
                MoveBottomSlider.IsEnabled = true;
                SliderFontSize.IsEnabled = true;
                ComboboxFonts.IsEnabled = true;

                if (textblock.HorizontalAlignment == HorizontalAlignment.Center) XAlignment.SelectedValuePath = "Center";
                else if (textblock.HorizontalAlignment == HorizontalAlignment.Left) XAlignment.SelectedValuePath = "Left";
                else if (textblock.HorizontalAlignment == HorizontalAlignment.Right) XAlignment.SelectedValuePath = "Right";

                if (textblock.VerticalAlignment == VerticalAlignment.Center) YAlignment.SelectedValuePath = "Center";
                else if (textblock.VerticalAlignment == VerticalAlignment.Top) YAlignment.SelectedValuePath = "Top";
                else if (textblock.VerticalAlignment == VerticalAlignment.Bottom) YAlignment.SelectedValuePath = "Bottom";

                MoveUpSlider.Value = textblock.Margin.Bottom;
                MoveLeftSlider.Value = textblock.Margin.Right;
                MoveRightSlider.Value = textblock.Margin.Left;
                MoveBottomSlider.Value = textblock.Margin.Top;

                SliderFontSize.Value = textblock.FontSize;

                ComboboxFonts.ItemsSource = allFonts;
                ComboboxFonts.SelectedValuePath = textblock.FontFamily.ToString();
            }
            catch
            {

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
