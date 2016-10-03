using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Label_v1
{
    class Label
    {
        public int varAddButton = 0;
        public double[] ArrRowColumn = new double[2] {1,1};
        public string labelName; 
        public ObservableCollection<string> ArrText = new ObservableCollection<string>();
        public ObservableCollection<double> ArrTextFont = new ObservableCollection<double>();
        public ObservableCollection<double> ArrTextLeftMargin = new ObservableCollection<double>();
        public ObservableCollection<double> ArrTextTopMargin = new ObservableCollection<double>();
        public ObservableCollection<string> ArrTextFontFamily = new ObservableCollection<string>();

        public int varImageCount = 0;
        public ObservableCollection<BitmapImage> ImageBitmap = new ObservableCollection<BitmapImage>();
        public ObservableCollection<double> ImageWidth = new ObservableCollection<double>();
        public ObservableCollection<double> ImageHeight = new ObservableCollection<double>();
        public ObservableCollection<string> ImageFileName = new ObservableCollection<string>();
        public ObservableCollection<double> ImageStretchAlignment = new ObservableCollection<double>();
        public ObservableCollection<double> ImageLeftMargin = new ObservableCollection<double>();
        public ObservableCollection<double> ImageTopMargin = new ObservableCollection<double>();
    }
}
