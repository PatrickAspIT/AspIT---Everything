using System.ComponentModel;

namespace Repository
{
    public class ClassNotify : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ClassNotify()
        {

        }

        /// <summary>
        /// Used to update values in the given Class when it is called
        /// </summary>
        /// <param name="strPropertyName">string - name of property that has to be updated</param>
        protected void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
