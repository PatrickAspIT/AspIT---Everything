using Repository;

namespace BIZ
{
    public class ClassBIZ
    {

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ClassBIZ()
        {
            // Initialises calckRes with ClassCalckRes
            // Gives access to ClassCalckRes
            calckRes = new ClassCalckRes();
        }

        /// <summary>
        /// Creates new variable to create new instance of ClassCalckRes
        /// </summary>
        public ClassCalckRes calckRes { get; set; }
    }
}
