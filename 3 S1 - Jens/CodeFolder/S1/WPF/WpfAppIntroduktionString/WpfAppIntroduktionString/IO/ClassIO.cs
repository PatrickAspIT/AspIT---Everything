using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppIntroduktionString.IO
{
    internal class ClassIO
    {
        public ClassIO()
        {

        }

        // Opgave 2.1
        public string GetTextForTextBox()
        {
            try
            {
                return File.ReadAllText("C:\\CodeFolder\\S1\\WPF\\Admiralen.txt");
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
