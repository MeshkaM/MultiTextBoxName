using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MultiTextBoxName
{
    public class CustomerModel : INotifyPropertyChanged
    {
        private int _ID;
        public int ID
        {
            get { return this._ID; }
            set
            {
                if (value != this._ID)
                {
                    this._ID = value;
                    OnPropertyChanged(nameof(_ID));
                }
            }
        }

        private string _FirstName;
        public string FirstName
        {
            get { return this._FirstName; }
            set
            { 
                if(value !=  this._FirstName)
                {
                    this._FirstName = value;
                    OnPropertyChanged(nameof(_FirstName));
                }
            }
        }

        private string _SecondName;
        public string SecondName
        {
            get { return this._SecondName; }
            set
            {
                if (value != this._SecondName)
                {
                    this._SecondName = value;
                    OnPropertyChanged(nameof(_SecondName));
                }
            }
        }

        private string _LastName;
        public string LastName
        {
            get { return this._LastName; }
            set
            {
                if (value != this._LastName)
                {
                    this._LastName = value;
                    OnPropertyChanged(nameof(_LastName));
                }
            }
        }


        private MultiNameTextBoxControl _FullName = new MultiNameTextBoxControl();
        public MultiNameTextBoxControl FullName
        {
            get { return this._FullName; }
            set
            {
                if (value != this._FullName)
                {
                    this._FullName = value;
                    OnPropertyChanged(nameof(_FullName));
                }
            }
        }


        //**************************************************************************************************************************************

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
