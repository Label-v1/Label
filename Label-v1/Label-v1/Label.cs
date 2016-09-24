using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Label_v1
{
    class Label
    {
        public int varAddButton = 0;
        public double[] ArrRowColumn = new double[2] {1,1}; 
        public List<string> ArrText = new List<string>();
        public List<double> ArrTextFont = new List<double>();
        public List<double> ArrTextLeftMargin = new List<double>();
        public List<double> ArrTextTopMargin = new List<double>();
        public List<double> ArrTextRightMargin = new List<double>();
        public List<double> ArrTextBottomMargin = new List<double>();
        public List<double> ArrTextHorizontalAlignMargin = new List<double>();
        public List<double> ArrTextVerticalAlignMargin = new List<double>();
        public string TextFont = "Arial";
    }
}
