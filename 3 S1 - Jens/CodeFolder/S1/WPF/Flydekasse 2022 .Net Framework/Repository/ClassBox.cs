using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class ClassBox : ClassNotify
    {
        // Box dimensioner i cm
        private double _boxHeight;        
        private double _boxWidth;
        private double _boxDepth;

        // Andre variabler
        private double _boxVolume;
        private double _boxBouyancy;
        private double _boxWeight;
        private int _materialDim;

        private ClassMaterial _boxMaterial;

        public ClassBox() 
        { 
            boxMaterial = new ClassMaterial();
            boxHeight = 0;
            boxDepth = 0;
            boxWidth = 0;
            boxVolume = 0;
            boxBouyancy = 0;
            boxWeight = 0;
            materialDim = 0;
        }

        public ClassMaterial boxMaterial
        {
            get { return _boxMaterial; }
            private set
            {
                if (_boxMaterial != value)
                {
                    _boxMaterial = value;
                }
                Notify("boxMaterial");
            }
        }

        // Set value of variables

        public double boxHeight
        {
            get { return _boxHeight; }
            set
            {
                if (_boxHeight != value)
                {
                    _boxHeight = value;
                }                
                Notify("boxHeight");
            }
        }

        public double boxWidth
        {
            get { return _boxWidth; }
            set
            {
                if (_boxWidth != value)
                {
                    _boxWidth = value;
                }                    
                Notify("boxWidth");
            }
        }

        public double boxDepth
        {
            get { return _boxDepth; }
            set
            {
                if (_boxDepth != value)
                {
                    _boxDepth = value;
                }                    
                Notify("boxDepth");
            }
        }

        public double boxVolume // Calculated in m3
        {
            get { return _boxVolume; }
            private set
            {
                if (_boxVolume != value)
                {
                    _boxVolume = value;
                }                    
                Notify("boxVolume");
            }
        }

        public double boxBouyancy
        {
            get { return _boxBouyancy; }
            private set
            {
                if (_boxBouyancy != value)
                {
                    _boxBouyancy = value;
                }                    
                Notify("boxBouyancy");
            }
        }

        public double boxWeight
        {
            get { return _boxWeight; }
            private set
            {
                if (_boxWeight != value)
                {
                    _boxWeight = value;
                }                    
                Notify("boxWeight");
            }
        }

        public int materialDim
        {
            get { return _materialDim; }
            private set
            {
                if (_materialDim != value)
                {
                    _materialDim = value;
                }                    
                Notify("materialDim");
            }
        }

        // Calculate All
        private void CalculateAll()
        {
            boxVolume = (boxHeight * boxDepth * boxWidth) * 100;
            
        }

        // CalculateMaterial
        private void CalculateMaterial()
        {

        }
    }
}
