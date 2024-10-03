using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    // Step 2
    public class ClassCalckRes : ClassNotify
    {
        private string _strCalcKNumber;
        private string _strCalckRes;
        private ClassTextRes _textRes;

        public ClassCalckRes()
        {
            textRes = new ClassTextRes();
            strCalckRes = "0";
            strCalckNumber = "0";
        }

        public string strCalckRes
        {
            get { return _strCalckRes; }
            private set 
            { 
                if (_strCalckRes != value)
                    _strCalckRes = value;
                Notify("strCalckRes");
            }
        }

        public string strCalckNumber
        {
            get { return _strCalcKNumber; }
            set
            {
                if ( _strCalcKNumber != value)
                {
                    if (int.TryParse(value, out int x))
                    {
                        _strCalcKNumber = value;
                        CalckNumber(value); 
                    }
                }
                Notify("strCalckNumber");
            }
        }

        public ClassTextRes textRes
        {
            get { return _textRes; }
            set
            {
                if (_textRes != value)
                    _textRes = value;
                Notify("textRes");
            }
        }

        private void CalckNumber(string inNumber)
        {
            int number = 0;
            if (inNumber != null)
                number = Convert.ToInt32(inNumber) * 1387;
            textRes.IsNumberEven(number);
            strCalckRes = number.ToString();
        }
    }
}