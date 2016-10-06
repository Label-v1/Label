using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
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
        bool validState = false, imageValid=false, textMovedValid=false;
        string[] allFonts = Microsoft.Graphics.Canvas.Text.CanvasTextFormat.GetSystemFontFamilies();
        UIElement movableElement;
        PointerPoint ptr;
        //Main Function
        public Screen2_CreateLabel()
        {
            this.InitializeComponent();
            validState = true;
            foreach(string x in allFonts)
            {
                ComboboxFonts.Items.Add(x);
            }
        }


        //Defualt Functions
        private void RowValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (!validState) return;
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
            if (!validState) return;
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
            if (!validState) return;
            try
            {
                funcCreateTextbox();
                ++label.varAddButton;
                if (label.varAddButton > 0)
                {
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
            if (!validState) return;
            try
            {
                funcRemoveTextbox();
                label.varAddButton--;
                if (label.varAddButton == 0)
                {
                    SubButton.IsEnabled = false;
                }
                 funcCreateLabel();
            }
            catch
            {

            }
        }

        private void BackButtonClicked(object sender, RoutedEventArgs e)
        {
            if (!validState) return;
            if (Frame.CanGoBack) {
                Frame.GoBack();
            }
        }
        private void LabelNameTextBoxChanged(object sender, TextChangedEventArgs e)
        {
            if (!validState) return;
            try
            {
                label.labelName = Textbox0.Text;
            }
            catch
            {

            }
        }


   //TextBlock functions

        private void SliderFontSizeChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (!validState) return;
            try
            {
                (PreviewLabelGrid.Children.ElementAt(selectedIndex) as TextBlock).FontSize = SliderFontSize.Value;
                label.ArrTextFont[selectedIndex] = SliderFontSize.Value;
            }
            catch
            {

            }
        }

        private void ComboboxFontsChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!validState) return;
            try
            {
                (PreviewLabelGrid.Children.ElementAt(selectedIndex) as TextBlock).FontFamily = new FontFamily(ComboboxFonts.SelectedItem.ToString());
                label.ArrTextFontFamily[selectedIndex] = ComboboxFonts.SelectedItem.ToString();
            }
            catch
            {

            }
           
        }


        private void MoreSettingsOkClicked(object sender, RoutedEventArgs e)
        {
            if (!validState) return;
            CreateLabelSettingsScrollViewer.Visibility = Visibility.Visible;
            MoreSettingsScrollView.Visibility = Visibility.Collapsed;
           
            SliderFontSize.IsEnabled = false;
            ComboboxFonts.IsEnabled = false;

            StatusTextBlock.Text = "Select a Text Block";
            StackStatusTextBlock.BorderThickness = new Thickness(0);
            StackStatusTextBlock.BorderBrush = new SolidColorBrush(Colors.Transparent);
        }

        //Custom Functions

        void funcClearLabel()
        {
            if (!validState) return;
            PreviewLabelGrid.Children.Clear();
        }

        void funcCreateTextbox()
        {
            if (!validState) return;
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

            int rnd = RandomGenerator(0);
            int check = 0;
            foreach (double x in label.ArrTextLeftMargin)
            {
                while (check == 0)
                {
                    if ((x + 20) <= rnd || (x - 20) >= rnd) break;
                    else rnd = RandomGenerator(0);
                }
            }
            label.ArrTextLeftMargin.Insert(label.varAddButton, rnd);
            rnd = RandomGenerator(1);
            foreach (double x in label.ArrTextTopMargin)
            {
                while (check == 0)
                {
                    if((x + 20) <= rnd || (x - 20) >= rnd) break;
                    else rnd = RandomGenerator(1);
                }
            }
            label.ArrTextTopMargin.Insert(label.varAddButton, rnd);
            label.ArrTextFont.Insert(label.varAddButton, 15);
            label.ArrTextFontFamily.Insert(label.varAddButton,"Arial");
            label.ArrText.Insert(label.varAddButton, "Text Line " + (label.varAddButton + 1));

            StackButton.Children.Add(button);

            StackTextBox.Children.Add(textbox);
        }
        private int RandomGenerator(int x)
        {
            Random rnd = new Random();
            if(x == 0)
            {
                int leftMargin = rnd.Next((int)PreviewLabelGrid.ActualWidth/2 - 1);
                return leftMargin;
            }
            else if(x == 1)
            {
                int topMargin = rnd.Next((int)PreviewLabelGrid.ActualHeight - 1);
                return topMargin;
            }
            return 0;         
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!validState) return;
            var button = sender as Button;
            int num = Convert.ToInt32(button.Name);
            StackButton.Children.RemoveAt(num);
            StackTextBox.Children.RemoveAt(num);

            label.ArrText.RemoveAt(num);
            label.ArrTextLeftMargin.RemoveAt(num);
            label.ArrTextTopMargin.RemoveAt(num);
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
            if (!validState) return;
            StackTextBox.Children.RemoveAt(label.varAddButton - 1);
            StackButton.Children.RemoveAt(label.varAddButton - 1);
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!validState) return;
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
            if (!validState) return;
            funcClearLabel();
            for(int i=0; i<label.varAddButton; i++)
            {
                var textblock = new TextBlock();
                textblock.Name = i.ToString();
                textblock.FontSize = label.ArrTextFont[i];
                textblock.FontFamily = new FontFamily(label.ArrTextFontFamily[i]);
                textblock.Foreground = new SolidColorBrush(Colors.Black);
                textblock.Text = label.ArrText[i];
                textblock.Tapped += Textblock_Tapped;
                textblock.PointerPressed += Textblock_PointerPressed;
                textblock.Margin = new Thickness(label.ArrTextLeftMargin[i], label.ArrTextTopMargin[i],0,0);
                textblock.HorizontalAlignment = HorizontalAlignment.Left;
                textblock.VerticalAlignment = VerticalAlignment.Top;
                
                PreviewLabelGrid.Children.Add(textblock);

            }
            if (!imageValid) return;

            for(int i = 0; i<label.varImageCount; i++)
            {
                var image = new Image();
                image.Name = label.ImageFileName[i];
                image.Source = label.ImageBitmap[i];
                image.Width = label.ImageWidth[i];
                image.Height = label.ImageHeight[i];
                image.Margin = new Thickness(label.ImageLeftMargin[i], label.ImageTopMargin[i], 0, 0);
                image.Tapped += Image_Tapped;image.HorizontalAlignment = HorizontalAlignment.Left;
                image.VerticalAlignment = VerticalAlignment.Top;
                if (label.ImageStretchAlignment[i] == 0) image.Stretch = Stretch.None;
                else if (label.ImageStretchAlignment[i] == 1) image.Stretch = Stretch.Fill;
                else if (label.ImageStretchAlignment[i] == 2) image.Stretch = Stretch.Uniform;
                else if (label.ImageStretchAlignment[i] == 3) image.Stretch = Stretch.UniformToFill;
                
                PreviewLabelGrid.Children.Add(image);
            }


        }
        private void Textblock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (!validState) return;
            try
            {
                validState = false;

                CreateLabelSettingsScrollViewer.Visibility = Visibility.Collapsed;
                MoreSettingsScrollView.Visibility = Visibility.Visible;

                var textblock = sender as TextBlock;
                selectedIndex = Convert.ToInt32(textblock.Name);

                StatusTextBlock.Text = textblock.Text;
                StackStatusTextBlock.BorderThickness = new Thickness(2);
                StackStatusTextBlock.BorderBrush = new SolidColorBrush(Colors.Wheat);

                SliderFontSize.IsEnabled = true;
                ComboboxFonts.IsEnabled = true;

                ComboboxFonts.SelectedIndex = ComboboxFonts.Items.IndexOf(label.ArrTextFontFamily[selectedIndex]);
                SliderFontSize.Value = label.ArrTextFont[selectedIndex];

                validState = true;
            }
            catch
            {

            }

        }

        //TextBlock Pointer
        private void Textblock_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            movableElement = sender as UIElement;
            ptr = e.GetCurrentPoint(movableElement);
            textMovedValid = true;
        }

        private void TextBlock_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            e.Handled = true;
            textMovedValid = false;
        }
        private void Textblock_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            e.Handled = true;
            textMovedValid = false;
            ptr = null;
        }

        private void Textblock_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (!textMovedValid) return;
            try
            {
                PointerPoint ptrtemp = e.GetCurrentPoint(movableElement);
                if (!ptrtemp.IsInContact) return;

                var textblock = movableElement as TextBlock;
                double marginX = ptrtemp.Position.X - ptr.Position.X + textblock.Margin.Left;
                double marginY = ptrtemp.Position.Y - ptr.Position.Y + textblock.Margin.Top;
                e.Handled = true;
                        if (marginX < 0 && marginY < 0) textblock.Margin = new Thickness(textblock.Margin.Left, textblock.Margin.Top, 0, 0);
                        else if (marginX < 0 && marginY >= 0) textblock.Margin = new Thickness(textblock.Margin.Left, marginY, 0, 0);
                        else if (marginX >= 0 && marginY < 0) textblock.Margin = new Thickness(marginX, textblock.Margin.Top, 0, 0);
                        else if (marginX >= 0 && marginY >= 0) textblock.Margin = new Thickness(marginX, marginY, 0, 0);
                        label.ArrTextLeftMargin[Convert.ToInt32(textblock.Name)] = textblock.Margin.Left;
                        label.ArrTextTopMargin[Convert.ToInt32(textblock.Name)] = textblock.Margin.Top;
            }
            catch
            {

            }
        }

        private void StateChangedOfUI(object sender, VisualStateChangedEventArgs e)
        {
         
            double phoneWidth = 350;
            double phoneHeight = 210;
            double desktopWidth = 500;
            double desktopHeight = 300;
            if(Window.Current.Bounds.Width >= 800)
            {
                for(int i = 0; i<label.ArrTextLeftMargin.Count; i++)
                {
                    label.ArrTextLeftMargin[i] = (desktopWidth / phoneWidth) * label.ArrTextLeftMargin[i];
                    label.ArrTextTopMargin[i] = (desktopHeight / phoneHeight) * label.ArrTextTopMargin[i];
                    label.ArrTextFont[i] = (desktopHeight * desktopWidth) / (phoneHeight * phoneWidth) * label.ArrTextFont[i];
                }
                
            }
            else if(Window.Current.Bounds.Width > 0)
            {
                for (int i = 0; i < label.ArrTextLeftMargin.Count; i++)
                {
                    label.ArrTextLeftMargin[i] = (phoneWidth / desktopWidth) * label.ArrTextLeftMargin[i];
                    label.ArrTextTopMargin[i] = (phoneHeight / desktopHeight) * label.ArrTextTopMargin[i];
                    label.ArrTextFont[i] = (phoneHeight * phoneWidth) / (desktopHeight * desktopWidth) * label.ArrTextFont[i];
                }
            }
            funcCreateLabel();
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {

           /* MoreSettingsScrollView.Visibility = Visibility.Collapsed;
            ImageSettings.Visibility = Visibility.Visible;
            */
        }   

        private async void ImageButtonClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                string FileName = Textbox0.Text.ToString();
                StorageFolder _Folder = ApplicationData.Current.LocalFolder;

                var picker = new Windows.Storage.Pickers.FileOpenPicker();
                picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
                picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
                picker.FileTypeFilter.Add(".jpg");
                picker.FileTypeFilter.Add(".jpeg");
                picker.FileTypeFilter.Add(".png");

                StorageFile file = await picker.PickSingleFileAsync();

                if (file != null)
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    FileRandomAccessStream stream = (FileRandomAccessStream)await file.OpenAsync(FileAccessMode.Read);
                    bitmapImage.SetSource(stream);

                    ++label.varImageCount;

                    label.ImageFileName.Add("Image_" + label.varImageCount);
                    label.ImageBitmap.Add(bitmapImage);
                    label.ImageWidth.Add(70);
                    label.ImageHeight.Add(70);
                    label.ImageStretchAlignment.Add(2);
                    label.ImageLeftMargin.Add(0);
                    label.ImageTopMargin.Add(0);
                 
                    imageValid = true;
                    funcCreateLabel();
                }

            }catch
                {

                }
            
            }

        
        }
    }
