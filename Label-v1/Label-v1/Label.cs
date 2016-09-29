using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label_v1
{
    class Label
    {
        public int varAddButton = 0;
        public double[] ArrRowColumn = new double[2] {1,1}; 
        public ObservableCollection<string> ArrText = new ObservableCollection<string>();
        public ObservableCollection<double> ArrTextFont = new ObservableCollection<double>();
        public ObservableCollection<double> ArrTextLeftMargin = new ObservableCollection<double>();
        public ObservableCollection<double> ArrTextTopMargin = new ObservableCollection<double>();
        public ObservableCollection<double> ArrTextRightMargin = new ObservableCollection<double>();
        public ObservableCollection<double> ArrTextBottomMargin = new ObservableCollection<double>();
        public ObservableCollection<double> ArrTextHorizontalAlignMargin = new ObservableCollection<double>();
        public ObservableCollection<double> ArrTextVerticalAlignMargin = new ObservableCollection<double>();
        public ObservableCollection<string> ArrTextFontFamily = new ObservableCollection<string>();
    }
}
