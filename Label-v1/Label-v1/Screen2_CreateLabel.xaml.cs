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
            if (label.varAddButton == 0) {
                SubButton.IsEnabled = true;
                MoreSettingsButton.IsEnabled = true;
                label.varAddButton++;

                Textbox1.Visibility = Visibility.Visible;

                MoreSettingsLine1.Visibility = Visibility.Visible;
                TextAlignment1.Visibility = Visibility.Visible;
                FontStack1.Visibility = Visibility.Visible;
                LeftMarginStack1.Visibility = Visibility.Visible;
                TopMarginStack1.Visibility = Visibility.Visible;
                RightMarginStack1.Visibility = Visibility.Visible;
                BottomMarginStack1.Visibility = Visibility.Visible;

                ComboboxTextAlignment1.Visibility = Visibility.Visible;
                FontSliderStack1.Visibility = Visibility.Visible;
                MarginSliderStack1.Visibility = Visibility.Visible;
                MarginSliderStack2.Visibility = Visibility.Visible;
                MarginSliderStack3.Visibility = Visibility.Visible;
                MarginSliderStack4.Visibility = Visibility.Visible;
            }
            else if (label.varAddButton == 1)
            {
                label.varAddButton++;

                Textbox2.Visibility = Visibility.Visible;
                MoreSettingsLine2.Visibility = Visibility.Visible;
                TextAlignment2.Visibility = Visibility.Visible;
                FontStack2.Visibility = Visibility.Visible;
                LeftMarginStack2.Visibility = Visibility.Visible;
                TopMarginStack2.Visibility = Visibility.Visible;
                RightMarginStack2.Visibility = Visibility.Visible;
                BottomMarginStack2.Visibility = Visibility.Visible;

                ComboboxTextAlignment2.Visibility = Visibility.Visible;
                FontSliderStack2.Visibility = Visibility.Visible;
                MarginSliderStack5.Visibility = Visibility.Visible;
                MarginSliderStack6.Visibility = Visibility.Visible;
                MarginSliderStack7.Visibility = Visibility.Visible;
                MarginSliderStack8.Visibility = Visibility.Visible;
            }
            else if (label.varAddButton == 2)
            {
                label.varAddButton++;

                Textbox3.Visibility = Visibility.Visible;
                MoreSettingsLine3.Visibility = Visibility.Visible;
                TextAlignment3.Visibility = Visibility.Visible;
                FontStack3.Visibility = Visibility.Visible;
                LeftMarginStack3.Visibility = Visibility.Visible;
                TopMarginStack3.Visibility = Visibility.Visible;
                RightMarginStack3.Visibility = Visibility.Visible;
                BottomMarginStack3.Visibility = Visibility.Visible;

                ComboboxTextAlignment3.Visibility = Visibility.Visible;
                FontSliderStack3.Visibility = Visibility.Visible;
                MarginSliderStack9.Visibility = Visibility.Visible;
                MarginSliderStack10.Visibility = Visibility.Visible;
                MarginSliderStack11.Visibility = Visibility.Visible;
                MarginSliderStack12.Visibility = Visibility.Visible;
            }
            else if (label.varAddButton == 3)
            {
                label.varAddButton++;

                Textbox4.Visibility = Visibility.Visible;
                MoreSettingsLine4.Visibility = Visibility.Visible;
                TextAlignment4.Visibility = Visibility.Visible;
                FontStack4.Visibility = Visibility.Visible;
                LeftMarginStack4.Visibility = Visibility.Visible;
                TopMarginStack4.Visibility = Visibility.Visible;
                RightMarginStack4.Visibility = Visibility.Visible;
                BottomMarginStack4.Visibility = Visibility.Visible;

                ComboboxTextAlignment4.Visibility = Visibility.Visible;
                FontSliderStack4.Visibility = Visibility.Visible;
                MarginSliderStack13.Visibility = Visibility.Visible;
                MarginSliderStack14.Visibility = Visibility.Visible;
                MarginSliderStack15.Visibility = Visibility.Visible;
                MarginSliderStack16.Visibility = Visibility.Visible;
            }
            else if (label.varAddButton == 4)
            {
                label.varAddButton++;

                Textbox5.Visibility = Visibility.Visible;
                MoreSettingsLine5.Visibility = Visibility.Visible;
                TextAlignment5.Visibility = Visibility.Visible;
                FontStack5.Visibility = Visibility.Visible;
                LeftMarginStack5.Visibility = Visibility.Visible;
                TopMarginStack5.Visibility = Visibility.Visible;
                RightMarginStack5.Visibility = Visibility.Visible;
                BottomMarginStack5.Visibility = Visibility.Visible;

                ComboboxTextAlignment5.Visibility = Visibility.Visible;
                FontSliderStack5.Visibility = Visibility.Visible;
                MarginSliderStack17.Visibility = Visibility.Visible;
                MarginSliderStack18.Visibility = Visibility.Visible;
                MarginSliderStack19.Visibility = Visibility.Visible;
                MarginSliderStack20.Visibility = Visibility.Visible;
            }
            else if (label.varAddButton == 5)
            {
                label.varAddButton++;

                Textbox6.Visibility = Visibility.Visible;
                MoreSettingsLine6.Visibility = Visibility.Visible;
                TextAlignment6.Visibility = Visibility.Visible;
                FontStack6.Visibility = Visibility.Visible;
                LeftMarginStack6.Visibility = Visibility.Visible;
                TopMarginStack6.Visibility = Visibility.Visible;
                RightMarginStack6.Visibility = Visibility.Visible;
                BottomMarginStack6.Visibility = Visibility.Visible;

                ComboboxTextAlignment6.Visibility = Visibility.Visible;
                FontSliderStack6.Visibility = Visibility.Visible;
                MarginSliderStack21.Visibility = Visibility.Visible;
                MarginSliderStack22.Visibility = Visibility.Visible;
                MarginSliderStack23.Visibility = Visibility.Visible;
                MarginSliderStack24.Visibility = Visibility.Visible;
            }
            else if (label.varAddButton == 6)
            {
                label.varAddButton++;
                AddButton.IsEnabled = false;

                Textbox7.Visibility = Visibility.Visible;
                MoreSettingsLine7.Visibility = Visibility.Visible;
                TextAlignment7.Visibility = Visibility.Visible;
                FontStack7.Visibility = Visibility.Visible;
                LeftMarginStack7.Visibility = Visibility.Visible;
                TopMarginStack7.Visibility = Visibility.Visible;
                RightMarginStack7.Visibility = Visibility.Visible;
                BottomMarginStack7.Visibility = Visibility.Visible;

                ComboboxTextAlignment7.Visibility = Visibility.Visible;
                FontSliderStack7.Visibility = Visibility.Visible;
                MarginSliderStack25.Visibility = Visibility.Visible;
                MarginSliderStack26.Visibility = Visibility.Visible;
                MarginSliderStack27.Visibility = Visibility.Visible;
                MarginSliderStack28.Visibility = Visibility.Visible;
            }
            funcCreateRows();
        }

        private void SubButtonClicked(object sender, RoutedEventArgs e)
        {
            if (label.varAddButton == 7) {
                AddButton.IsEnabled = true;
                label.varAddButton--;
                Textbox7.Visibility = Visibility.Collapsed;

                MoreSettingsLine7.Visibility = Visibility.Collapsed;
                TextAlignment7.Visibility = Visibility.Collapsed;
                FontStack7.Visibility = Visibility.Collapsed;
                LeftMarginStack7.Visibility = Visibility.Collapsed;
                TopMarginStack7.Visibility = Visibility.Collapsed;
                RightMarginStack7.Visibility = Visibility.Collapsed;
                BottomMarginStack7.Visibility = Visibility.Collapsed;

                ComboboxTextAlignment7.Visibility = Visibility.Collapsed;
                FontSliderStack7.Visibility = Visibility.Collapsed;
                MarginSliderStack25.Visibility = Visibility.Collapsed;
                MarginSliderStack26.Visibility = Visibility.Collapsed;
                MarginSliderStack27.Visibility = Visibility.Collapsed;
                MarginSliderStack28.Visibility = Visibility.Collapsed;
            }
            else if (label.varAddButton == 6) {
                label.varAddButton--;
                Textbox6.Visibility = Visibility.Collapsed;

                MoreSettingsLine6.Visibility = Visibility.Collapsed;
                TextAlignment6.Visibility = Visibility.Collapsed;
                FontStack6.Visibility = Visibility.Collapsed;
                LeftMarginStack6.Visibility = Visibility.Collapsed;
                TopMarginStack6.Visibility = Visibility.Collapsed;
                RightMarginStack6.Visibility = Visibility.Collapsed;
                BottomMarginStack6.Visibility = Visibility.Collapsed;

                ComboboxTextAlignment6.Visibility = Visibility.Collapsed;
                FontSliderStack6.Visibility = Visibility.Collapsed;
                MarginSliderStack21.Visibility = Visibility.Collapsed;
                MarginSliderStack22.Visibility = Visibility.Collapsed;
                MarginSliderStack23.Visibility = Visibility.Collapsed;
                MarginSliderStack24.Visibility = Visibility.Collapsed;
            }
            else if (label.varAddButton == 5)
            {
                label.varAddButton--;
                Textbox5.Visibility = Visibility.Collapsed;

                MoreSettingsLine5.Visibility = Visibility.Collapsed;
                TextAlignment5.Visibility = Visibility.Collapsed;
                FontStack5.Visibility = Visibility.Collapsed;
                LeftMarginStack5.Visibility = Visibility.Collapsed;
                TopMarginStack5.Visibility = Visibility.Collapsed;
                RightMarginStack5.Visibility = Visibility.Collapsed;
                BottomMarginStack5.Visibility = Visibility.Collapsed;

                ComboboxTextAlignment5.Visibility = Visibility.Collapsed;
                FontSliderStack5.Visibility = Visibility.Collapsed;
                MarginSliderStack17.Visibility = Visibility.Collapsed;
                MarginSliderStack18.Visibility = Visibility.Collapsed;
                MarginSliderStack19.Visibility = Visibility.Collapsed;
                MarginSliderStack20.Visibility = Visibility.Collapsed;
            }
            else if (label.varAddButton == 4)
            {
                label.varAddButton--;
                Textbox4.Visibility = Visibility.Collapsed;

                MoreSettingsLine4.Visibility = Visibility.Collapsed;
                TextAlignment4.Visibility = Visibility.Collapsed;
                FontStack4.Visibility = Visibility.Collapsed;
                LeftMarginStack4.Visibility = Visibility.Collapsed;
                TopMarginStack4.Visibility = Visibility.Collapsed;
                RightMarginStack4.Visibility = Visibility.Collapsed;
                BottomMarginStack4.Visibility = Visibility.Collapsed;

                ComboboxTextAlignment4.Visibility = Visibility.Collapsed;
                FontSliderStack4.Visibility = Visibility.Collapsed;
                MarginSliderStack13.Visibility = Visibility.Collapsed;
                MarginSliderStack14.Visibility = Visibility.Collapsed;
                MarginSliderStack15.Visibility = Visibility.Collapsed;
                MarginSliderStack16.Visibility = Visibility.Collapsed;
            }
            else if (label.varAddButton == 3)
            {
                label.varAddButton--;
                Textbox3.Visibility = Visibility.Collapsed;

                MoreSettingsLine3.Visibility = Visibility.Collapsed;
                TextAlignment3.Visibility = Visibility.Collapsed;
                FontStack3.Visibility = Visibility.Collapsed;
                LeftMarginStack3.Visibility = Visibility.Collapsed;
                TopMarginStack3.Visibility = Visibility.Collapsed;
                RightMarginStack3.Visibility = Visibility.Collapsed;
                BottomMarginStack3.Visibility = Visibility.Collapsed;

                ComboboxTextAlignment3.Visibility = Visibility.Collapsed;
                FontSliderStack3.Visibility = Visibility.Collapsed;
                MarginSliderStack9.Visibility = Visibility.Collapsed;
                MarginSliderStack10.Visibility = Visibility.Collapsed;
                MarginSliderStack11.Visibility = Visibility.Collapsed;
                MarginSliderStack12.Visibility = Visibility.Collapsed;
            }
            else if (label.varAddButton == 2)
            {
                label.varAddButton--;
                Textbox2.Visibility = Visibility.Collapsed;

                MoreSettingsLine2.Visibility = Visibility.Collapsed;
                TextAlignment2.Visibility = Visibility.Collapsed;
                FontStack2.Visibility = Visibility.Collapsed;
                LeftMarginStack2.Visibility = Visibility.Collapsed;
                TopMarginStack2.Visibility = Visibility.Collapsed;
                RightMarginStack2.Visibility = Visibility.Collapsed;
                BottomMarginStack2.Visibility = Visibility.Collapsed;

                ComboboxTextAlignment2.Visibility = Visibility.Collapsed;
                FontSliderStack2.Visibility = Visibility.Collapsed;
                MarginSliderStack5.Visibility = Visibility.Collapsed;
                MarginSliderStack6.Visibility = Visibility.Collapsed;
                MarginSliderStack7.Visibility = Visibility.Collapsed;
                MarginSliderStack8.Visibility = Visibility.Collapsed;
            }
            else if (label.varAddButton == 1)
            {
                SubButton.IsEnabled = false;
                MoreSettingsButton.IsEnabled = false;
                label.varAddButton--;
                Textbox1.Visibility = Visibility.Collapsed;

                MoreSettingsLine1.Visibility = Visibility.Collapsed;
                TextAlignment1.Visibility = Visibility.Collapsed;
                FontStack1.Visibility = Visibility.Collapsed;
                LeftMarginStack1.Visibility = Visibility.Collapsed;
                TopMarginStack1.Visibility = Visibility.Collapsed;
                RightMarginStack1.Visibility = Visibility.Collapsed;
                BottomMarginStack1.Visibility = Visibility.Collapsed;

                ComboboxTextAlignment1.Visibility = Visibility.Collapsed;
                FontSliderStack1.Visibility = Visibility.Collapsed;
                MarginSliderStack1.Visibility = Visibility.Collapsed;
                MarginSliderStack2.Visibility = Visibility.Collapsed;
                MarginSliderStack3.Visibility = Visibility.Collapsed;
                MarginSliderStack4.Visibility = Visibility.Collapsed;
            }
            else if (label.varAddButton == 0)
            {
                SubButton.IsEnabled = false;
                MoreSettingsButton.IsEnabled = false;
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
            try
            {
                label.ArrText[0] = Textbox0.Text;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void Textbox1Changed(object sender, TextChangedEventArgs e)
        {
            try
            {
                label.ArrText[1] = Textbox1.Text;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void Textbox2Changed(object sender, TextChangedEventArgs e)
        {
             try
            {
                label.ArrText[2] = Textbox2.Text;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void Textbox3Changed(object sender, TextChangedEventArgs e)
        {
            try
            {
                label.ArrText[3] = Textbox3.Text;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void Textbox4Changed(object sender, TextChangedEventArgs e)
        {
            try
            {
                label.ArrText[4] = Textbox4.Text;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void Textbox5Changed(object sender, TextChangedEventArgs e)
        {
            try
            {
                label.ArrText[5] = Textbox5.Text;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void Textbox6Changed(object sender, TextChangedEventArgs e)
        {
            try
            {
                label.ArrText[6] = Textbox6.Text;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void Textbox7Changed(object sender, TextChangedEventArgs e)
        {
            try
            {
                label.ArrText[7] = Textbox7.Text;
                funcCreateRows();
            }
            catch
            {

            }
        }

        //Not to run at startup
        int notToRunAtStartup1 = 42,notToRunAtStartup2=42;

        private void combobox1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                comboboxCheck(sender, 0);
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void combobox2(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                comboboxCheck(sender, 1);
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void combobox3(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                comboboxCheck(sender, 2);
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void combobox4(object sender, SelectionChangedEventArgs e)
        {
             try
            {
                comboboxCheck(sender, 3);
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void combobox5(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                comboboxCheck(sender, 4);
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void combobox6(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                comboboxCheck(sender, 5);
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void combobox7(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                comboboxCheck(sender, 6);
                funcCreateRows();
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

        private void MoreSettingsButtonSaved(object sender, RoutedEventArgs e)
        {
            MoreSettingsScrollView.Visibility = Visibility.Collapsed;
            CreateLabelSettingsScrollViewer.Visibility = Visibility.Visible;
        }



        private void FontSliderChanged1(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrFont[0] = FontSlider1.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void FontSliderChanged2(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrFont[1] = FontSlider2.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void FontSliderChanged3(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrFont[2] = FontSlider3.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void FontSliderChanged4(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrFont[3] = FontSlider4.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void FontSliderChanged5(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrFont[4] = FontSlider5.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void FontSliderChanged6(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrFont[5] = FontSlider6.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void FontSliderChanged7(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrFont[6] = FontSlider7.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }


        private void MarginSliderchanged28(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrBottomMargin[6] = MarginSlider28.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged27(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrRightMargin[6] = MarginSlider27.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged26(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrTopMargin[6] = MarginSlider26.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged25(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrLeftMargin[6] = MarginSlider25.Value;
                funcCreateRows();
            }
            catch
            {

            }        
        }

        private void MarginSliderchanged24(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrBottomMargin[5] = MarginSlider24.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged23(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrRightMargin[5] = MarginSlider23.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged22(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrTopMargin[5] = MarginSlider22.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged21(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrLeftMargin[5] = MarginSlider21.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged20(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrBottomMargin[4] = MarginSlider20.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged19(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrRightMargin[4] = MarginSlider19.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged18(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrTopMargin[4] = MarginSlider18.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged17(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrLeftMargin[4] = MarginSlider17.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged16(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrBottomMargin[3] = MarginSlider16.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged15(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrRightMargin[3] = MarginSlider15.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged14(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrTopMargin[3] = MarginSlider14.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged13(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrLeftMargin[3] = MarginSlider13.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged12(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrBottomMargin[2] = MarginSlider12.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged11(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrRightMargin[2] = MarginSlider11.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged10(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrTopMargin[2] = MarginSlider10.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged9(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrLeftMargin[2] = MarginSlider9.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged8(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrBottomMargin[1] = MarginSlider8.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged7(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrRightMargin[1] = MarginSlider7.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged6(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrTopMargin[1] = MarginSlider6.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged5(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrLeftMargin[1] = MarginSlider5.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged4(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrBottomMargin[0] = MarginSlider4.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged3(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrRightMargin[0] = MarginSlider3.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged2(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrTopMargin[0] = MarginSlider2.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }

        private void MarginSliderchanged1(object sender, RangeBaseValueChangedEventArgs e)
        {
            try
            {
                label.ArrLeftMargin[0] = MarginSlider1.Value;
                funcCreateRows();
            }
            catch
            {

            }
        }


        //Custom Functions

        void funcClearRows()
        {
            if(notToRunAtStartup1 > 0)
            {
                notToRunAtStartup1--;
                return;
            }

            PreviewLabelGrid.Children.Clear();
            PreviewLabelGrid.RowDefinitions.Clear();
        }

        void funcCreateRows() {
            funcClearRows();

            if (notToRunAtStartup2 > 0)
            {
                notToRunAtStartup2--;
                return;
            }

            for (int i = 0; i < label.varAddButton; i++)
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

                if (label.ArrAlignMargin[i] == 0) textblck.TextAlignment = TextAlignment.Center;
                else if (label.ArrAlignMargin[i] == 1) textblck.TextAlignment = TextAlignment.Left;
                else if (label.ArrAlignMargin[i] == 2) textblck.TextAlignment = TextAlignment.Right;

                textblck.Margin = new Thickness(label.ArrLeftMargin[i], label.ArrTopMargin[i], label.ArrRightMargin[i], label.ArrBottomMargin[i]);
                textblck.FontSize = label.ArrFont[i];
                textblck.Text = label.ArrText[i+1];
                textblck.Foreground = new SolidColorBrush(Colors.Black);
                stack.Children.Add(textblck);

            }
        }

        void comboboxCheck(object sender , int number)
        {
            var comboBox = sender as ComboBox;
            if ((comboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Center") label.ArrAlignMargin[number] = 0;
            else if ((comboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Left") label.ArrAlignMargin[number] = 1;
            else if ((comboBox.SelectedItem as ComboBoxItem).Content.ToString() == "Right") label.ArrAlignMargin[number] = 2;
        }

   }
}
