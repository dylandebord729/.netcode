using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MemoryCalculator: Calculator
    {
        private string mValue = "";
        public void mClear() {
            mValue = "";
        }
        public void mRecall() { 
            displayString = mValue;
        }
        public void mSave() {
            mValue = displayString;
        }
        public void mPlus() { 
            decimal newVal = 0;
            if (mValue == "") {
                mValue = "0";
            }
            newVal = Convert.ToDecimal(mValue) + Convert.ToDecimal(displayString);
            mValue = newVal.ToString();
        }
    }
}
