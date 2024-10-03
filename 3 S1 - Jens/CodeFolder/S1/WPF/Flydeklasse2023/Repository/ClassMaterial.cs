using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassMaterial : ClassNotify
    {

        private double _treeWeight;
        private double _plasticWeight;
        private double _glassWeight;
        private double _ironWeight;

        public ClassMaterial() 
        {
            treeWeight = 0D;
            plasticWeight = 0D;
            glassWeight = 0D;
            ironWeight = 0D;
        }

        // Vægt i kg for træ, plast, glas og jern
        public double treeWeight
        {
            get { return _treeWeight; }
            private set
            {
                if (_treeWeight != value)
                {
                    _treeWeight = value;
                }
                Notify("treeWeight");
            }
        }
        public double plasticWeight
        {
            get { return _plasticWeight; }
            private set
            {
                if (_plasticWeight != value)
                {
                    _plasticWeight = value;
                }
                Notify("plasticWeight");
            }
        }
        public double glassWeight
        {
            get { return _glassWeight; }
            private set
            {
                if (_glassWeight != value)
                {
                    _glassWeight = value;
                }
                Notify("glassWeight");
            }
        }
        public double ironWeight
        {
            get { return _ironWeight; }
            private set
            {
                if (_ironWeight != value)
                {
                    _ironWeight = value;
                }
                Notify("ironWeight");
            }
        }
    }
}
