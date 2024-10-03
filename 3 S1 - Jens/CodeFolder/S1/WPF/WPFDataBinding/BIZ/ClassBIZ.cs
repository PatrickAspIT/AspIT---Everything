using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIZ;

namespace BIZ
{
    // Step 4
    public class ClassBiz : ClassNotify
    {
        public ClassBiz()
        {
            calckRes = new ClassCalckRes();
        }

        private ClassCalckRes _calckRes;

        public ClassCalckRes calckRes
        {
            get { return _calckRes; }
            set
            {
                if (_calckRes != value) 
                    _calckRes = value;
                Notify("calckRes");
            }
        }
    }
}