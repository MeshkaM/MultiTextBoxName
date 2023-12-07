using System.Linq;
using System.Windows;

namespace MultiTextBoxName
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = DataAccessLayer.LoadCustomer().FirstOrDefault();
        }
    }
}
