using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassTube : ClassNotify
    {

        private double _tubeLength;
        private double _tubeDiameter;
        private double _tubeWeight;
        private double _tubeBuoyancy;
        private double _tubeVolume;
        private ClassMaterial _tubeMaterial;
        private double _tubeMaterialDim;
        private double _tubeInnerVolume;

        public ClassTube()
        {
            tubeMaterial = new ClassMaterial();
			tubeDiameter = 0D;
			tubeWeight = 0D;
			tubeLength = 0D;
			tubeBuoyancy = 0D;
			tubeVolume = 0D;
			tubeMaterialDim = 0D;
			tubeInnerVolume = 0D;
        }

		public double tubeInnerVolume
		{
			get { return _tubeInnerVolume; }
			set
			{
				if (_tubeInnerVolume != value)
				{
					_tubeInnerVolume = value;
				}
				Notify("tubeInnerVolume");
			}
		}

		public double tubeMaterialDim
		{
			get { return _tubeMaterialDim; }
			set
			{
				if (_tubeMaterialDim != value)
				{
                    if (double.TryParse(value.ToString(), out double X))
                    {
                        _tubeMaterialDim = value;
                        CalculateAllTubes();
                    }
				}
				Notify("tubeMaterialDim");
			}
		}

		public ClassMaterial tubeMaterial
		{
			get { return _tubeMaterial; }
			set
			{
				if (_tubeMaterial != value)
				{
					_tubeMaterial = value;
				}
				Notify("tubeMaterial");
			}
		}

		public double tubeVolume
		{
			get { return _tubeVolume; }
			set
			{
				if (_tubeVolume != value)
				{
					_tubeVolume = value;
				}
				Notify("tubeVolume");
			}
		}

		public double tubeBuoyancy
		{
			get { return _tubeBuoyancy; }
			set
			{
				if (_tubeBuoyancy != value)
				{
					_tubeBuoyancy = value;
				}
				Notify("tubeBuoyancy");
			}
		}

		public double tubeWeight
		{
			get { return _tubeWeight; }
			set
			{
				if (_tubeWeight != value)
				{
					_tubeWeight = value;
				}
				Notify("tubeWeight");
			}
		}

		public double tubeDiameter
		{
			get { return _tubeDiameter; }
			set
			{
				if (_tubeDiameter != value)
				{
                    if (double.TryParse(value.ToString(), out double X))
                    {
                        _tubeDiameter = value;
                        CalculateAllTubes();
                    }
				}
				Notify("tubeDiameter");
			}
		}

		public double tubeLength
		{
			get { return _tubeLength; }
			set
			{
				if (_tubeLength != value)
				{
					if (double.TryParse(value.ToString(), out double X))
					{
                        _tubeLength = value;
                        CalculateAllTubes();
					}
				}
				Notify("tubeLength");
			}
		}

		private void CalculateAllTubes()
		{
			CalculateMaterialTube();
			double rad = tubeDiameter / 2D;
			tubeBuoyancy = ((rad * rad * Math.PI * tubeLength) / 1000) - tubeWeight;

			tubeVolume = (rad / 100D) * (rad / 100D) * Math.PI * (tubeLength / 100D);
		}

		private void CalculateMaterialTube()
		{
			double matWeight = tubeMaterial.materialWeight;
			double matDim = (tubeMaterialDim / 100D);

			double myMasse1 = 0;
			double myMasse2 = 0;

			double rad = tubeDiameter / 2D;

			double rad2 = (tubeDiameter / 2D) - (tubeMaterialDim / 10D);

			myMasse1 = (((rad / 100D) * (rad / 100D) * Math.PI) * tubeLength) * matWeight;
			myMasse2 = (((rad2 / 100D) * (rad2 / 100D) * Math.PI) * tubeLength) * matWeight;
			tubeInnerVolume = (((rad2 / 100D) * (rad2 / 100D) * Math.PI) * (tubeLength / 100));

			tubeWeight = (myMasse1 - myMasse2);
        }
	}
}
