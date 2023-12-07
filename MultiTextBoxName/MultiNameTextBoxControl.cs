using System.ComponentModel;

namespace MultiTextBoxName
{
    public class MultiNameTextBoxControl : ModelBase
    {
        private string _FirstName;
        public string FirstName
        {
            get => _FirstName;
            set
            {
                _FirstName = value;
                OnChange();
                OnPropertyChanged();
            }
        }

        private string _SecondName;
        public string SecondName
        {
            get => _SecondName;
            set
            {
                _SecondName = value;
                OnChange();
                OnPropertyChanged();
            }
        }

        private string _LastName;
        public string LastName
        {
            get => _LastName;
            set
            {
                _LastName = value;
                OnChange();
                OnPropertyChanged();
            }
        }


        private void OnChange()
        {
            FullName = FirstName + " " + SecondName + " " + LastName;
        }

        public string _FullName;
        public string FullName
        {
            get => _FullName;
            set
            {
                _FullName = (string)value;
                OnPropertyChanged();
            }
        }

    }

    public class ModelBase : System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "") 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
