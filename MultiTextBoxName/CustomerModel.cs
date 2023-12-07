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
                if (value != this._FirstName)
                {
                    this._FirstName = value;
                    OnChange();
                    OnPropertyChanged(nameof(_FirstName));
                }
            }
        }

        private string _MiddleName;
        public string MiddleName
        {
            get { return this._MiddleName; }
            set
            {
                if (value != this._MiddleName)
                {
                    this._MiddleName = value;
                    OnChange();
                    OnPropertyChanged(nameof(_MiddleName));
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
                    OnChange();
                    OnPropertyChanged(nameof(_LastName));
                }
            }
        }

        private void OnChange()
        {
            _FullName = FirstName + " " + MiddleName + " " + LastName;
        }

        public string _FullName;
        public string FullName
        {
            get { return this._FullName; }
        }


        //**************************************************************************************************************************************

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
