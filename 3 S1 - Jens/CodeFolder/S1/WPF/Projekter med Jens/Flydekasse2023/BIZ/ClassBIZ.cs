using IO;
using Repository;
using System.Collections.Generic;
using IO;
using System.Diagnostics;

namespace BIZ
{
    public class ClassBIZ : ClassNotify
    {

        private List<ClassMaterial> _listMaterial;
        private ClassBox _box;
        private string _matDim;
        private ClassMaterial _selectedMaterial;
        private ClassTube _tube;
        private ClassFileHandler _fileHandler;

        public ClassBIZ()
        {
			listMaterial = new List<ClassMaterial>();
			box = new ClassBox();
			tube = new ClassTube();
			fileHandler = new ClassFileHandler();
			matDim = "0";
			selectedMaterial = new ClassMaterial();
			SetUpMaterialList();

        }

		public ClassFileHandler fileHandler
        {
			get { return _fileHandler; }
			set
			{
				if (_fileHandler != value)
				{
                    _fileHandler = value;
				}
				Notify("myVar");
			}
		}

		public ClassTube tube
		{
			get { return _tube; }
			set
			{
				if (_tube != value)
				{
					_tube = value;
				}
				Notify("tube");
			}
		}

		public ClassMaterial selectedMaterial
		{
			get { return _selectedMaterial; }
			set
			{
				if (_selectedMaterial != value)
				{
					_selectedMaterial = value;
					box.boxMaterial = value;
					tube.tubeMaterial = value;
				}
			}
		}

		public string matDim
		{
			get { return _matDim; }
			set
			{
				if (_matDim != value)
				{
					if (double.TryParse(value, out double X))
					{
						_matDim = value;
						box.materialDimStr = value;
						tube.tubeMaterialDim = X;
					}
				}
			}
		}

		public ClassBox box
		{
			get { return _box; }
			set { _box = value; }
		}

		public List<ClassMaterial> listMaterial
        {
			get { return _listMaterial; }
			set
			{
				if (_listMaterial != value)
				{
                    _listMaterial = value;
				}
				Notify("listMaterial");
			}
		}

		private void SetUpMaterialList()
		{
			listMaterial.Add(new ClassMaterial("Træ", 0.987));
            listMaterial.Add(new ClassMaterial("Plast", 3.378));
            listMaterial.Add(new ClassMaterial("Glas", 14.251));
            listMaterial.Add(new ClassMaterial("Jern", 25.477));
        }

		public void BoxTextToFile()
		{
            string path = @"C:\CodeFolder\boxtext.txt";
            string text = "Box Report \n\n";
			text += $"Box Material: {selectedMaterial} \n";
			text += $"Box Material Thickness: {matDim} mm. \n";
            text += $"Box Height: {box.boxHeightStr} cm. \n";
            text += $"Box Width: {box.boxWideStr} cm. \n";
            text += $"Box Depth: {box.boxDepthStr} cm. \n";
            text += $"Box Volume: {box.boxVolume} m3 \n";
            text += $"Box Inner Volume: {box.boxInnerVolumen} m3 \n";
            text += $"Box Weight: {box.boxWeight} kg. \n";
            text += $"Box Buoyancy: {box.boxBuoyancy} kg. \n";

            fileHandler.WriteTextToFile(path, text);
			Process.Start(path);
        }

		public void TubeTextToFile()
		{
			string path = @"C:\CodeFolder\tubetext.txt";
            string text = "Tube Report \n\n";
            text += $"Tube Material: {selectedMaterial} \n";
            text += $"Tube Material Thickness: {matDim} mm. \n";
            text += $"Tube Diameter: {tube.tubeDiameter} cm. \n";
            text += $"Tube Length: {tube.tubeLength} cm. \n";
            text += $"Tube Volume: {tube.tubeVolume} m3 \n";
            text += $"Tube Inner Volume: {tube.tubeInnerVolume} m3 \n";
            text += $"Tube Weight: {tube.tubeWeight} kg. \n";
            text += $"Tube Buoyancy: {tube.tubeBuoyancy} kg. \n";

            fileHandler.WriteTextToFile(path, text);
			Process.Start(path);
        }
	}
}
