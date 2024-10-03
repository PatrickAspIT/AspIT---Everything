using System;

namespace Repository
{
    public class ClassCalckRes : ClassNotify
    {
        /// <summary>
        /// Creates variables to hold user input (_strValue) and output of calculation (_strCalckRes)
        /// Set to private so you cant change value from another place
        /// </summary>
        private string _strValue;
        private string _strCalckRes;

        /// <summary>
        /// Creates new variable to create new instance of ClassTextRes
        /// Set to private so you cant change value from another place
        /// </summary>
        private ClassTextRes _textRes;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ClassCalckRes()
        {
            // Initialises variables with a start value
            // Gives access to ClassTextRes
            textRes = new ClassTextRes();
            strCalckRes = "";
            strValue = "0";
        }

        /// <summary>
        /// Used to give TextRes a new value
        /// Set to public so you can access it and by association _textRes from another Class
        /// Outputs if strCalckRes output is even or un-even
        /// </summary>
        public ClassTextRes textRes
        {
            get { return _textRes; }
            set
            {
                if (_textRes != value)
                {
                    _textRes = value;
                }
                Notify("textRes");
            }
        }

        /// <summary>
        /// Used to give strCalckRes a new value
        /// Set to public so you can access it and by association _strCalckRes from another Class
        /// Outputs strValue * 1387 in method CalculateNewNumber()
        /// </summary>
        public string strCalckRes
        {
            get { return _strCalckRes; }
            set
            {
                if (_strCalckRes != value)
                {
                    _strCalckRes = value;
                }
                Notify("strCalckRes");
            }
        }

        /// <summary>
        /// Used to give strValue a new value
        /// Set to public so you can access it and by association _strValue from another Class
        /// Outputs user input as long as it's a number and runs the method CalculateThisNumber()
        /// 
        /// set: 
        /// Checks if value is different that what is already set
        /// Checks if value is empty, if so then it is set to "0"
        /// Checks if the value can be converted to int, if it can, then continue, else don't set _strValue to value
        /// Checks if the value * 1387 is bigger or equal to the max value that int can hold, or if the same value * 1387 is smaller than 0
        /// If any of the 2 is true, then set value to 1.549.294
        /// Set _strValue to value
        /// Run method CalculateThisNumber()
        /// </summary>
        public string strValue
        {
            get { return _strValue; }
            set
            {
                if (_strValue != value)
                {
                    if (value.Trim() == "")
                    {
                        value = "0";
                    }
                    if (int.TryParse(value, out int X))
                    {
                        if ((Convert.ToInt32(value) * 1387) >= (int.MaxValue) || (Convert.ToInt32(value) * 1387) < 0)
                        {
                            value = (int.MaxValue / 1387).ToString();
                        }
                        _strValue = value;
                        CalculateThisNumber(X);
                    }
                }
                Notify("strValue");
            }
        }

        /// <summary>
        /// Used to give value to strCalckRes and by association _strCalckRes, with a calculation
        /// Runs method IsNumberEven() in ClassTextRes with TextRes and by association _TextRes
        /// </summary>
        /// <param name="inNumber">int - Contains the number that has to be multiplied, given to strCalckRes and seen if the value is even or un-even</param>
        private void CalculateThisNumber(int inNumber)
        {
            int temp = inNumber * 1387;
            strCalckRes = temp.ToString();
            textRes.IsNumberEven(temp);
        }
    }
}
