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
        public string[] ArrText = new string[8] { "Label Name", "Line 1", "Line 2", "Line 3", "Line 4", "Line 5", "Line 6", "Line 7" };
        public double[] ArrFont = new double[7] {20,20,20,20,20,20,20};
        public double[] ArrLeftMargin = new double[7] { 0, 0, 0, 0, 0, 0, 0 };
        public double[] ArrTopMargin = new double[7] { 0, 0, 0, 0, 0, 0, 0 };
        public double[] ArrRightMargin = new double[7] { 0, 0, 0, 0, 0, 0, 0 };
        public double[] ArrBottomMargin = new double[7] { 0, 0, 0, 0, 0, 0, 0 };
        public double[] ArrAlignMargin = new double[7] { 0, 0, 0, 0, 0, 0, 0 };
    }
}
