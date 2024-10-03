namespace Repository
{
    public class ClassTextRes : ClassNotify
    {
        /// <summary>
        /// Creates variables to hold a value
        /// Set to private so you cant change value from another place
        /// </summary>
        private string _strTextRes;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ClassTextRes()
        {
            // Initialises variable with a start value
            strTextRes = "0";
        }

        /// <summary>
        /// Used to give strTextRes a new value
        /// Set to public so you can access it and by association _strTextRes from another Class
        /// set is set to private, so it can't be accessed from outside the class
        /// Outputs if strValue from ClassCalckRes is even or un-even
        /// </summary>
        public string strTextRes
        {
            get { return _strTextRes; }
            private set
            {
                if (_strTextRes != value)
                {
                    _strTextRes = value;
                }
                Notify("strTextRes");
            }
        }

        /// <summary>
        /// Called from method CalculateThisNumber() in ClassCalckRes
        /// Checks if the value, which is strValue, is even or un-even and based on that
        /// gives strTextRes and by association _strTextValue a value,
        /// </summary>
        /// <param name="inNumber">int - indeholder det tal der skal tjekkes</param>
        public void IsNumberEven(int inNumber)
        {
            // If strValue is 0 or hasn't been given a value
            if (inNumber == 0)
            {
                strTextRes = "Indtast et tal - Og du får et resultat !";
            }
            else
            {
                // If strValue is even using modulus
                if (inNumber % 2 == 0)
                {
                    strTextRes = $"Tallet {inNumber} er et LIGE tal";
                }
                // If strValue is un-even using modulus
                else
                {
                    strTextRes = $"Tallet {inNumber} er et U-LIGE tal";
                }
            }
        }
    }
}
