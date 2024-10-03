using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    // Step 3
    public class ClassTextRes : ClassNotify
    {
        public ClassTextRes()
        {
            strTextRes = "Indtast et heltal - Og du får et resultat !";
        }
        
        private string _strTextRes;

        public string strTextRes
        {
            get { return _strTextRes; }
            private set
            {
                if (_strTextRes != value)
                    _strTextRes = value;
                Notify("StrTextRes");
            }
        }

        public void IsNumberEven(int intNumber)
        {
            if (intNumber % 2 == 0)
                strTextRes = String.Format("Tallet {0} er et LIGE tal.", intNumber);
            else
                strTextRes = String.Format("Tallet {0} er et ULIGE tal.", intNumber);
        }
    }
}