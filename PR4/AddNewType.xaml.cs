using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PR4
{
    /// <summary>
    /// Логика взаимодействия для AddNewType.xaml
    /// </summary>
    public partial class AddNewType : Window
    {
        public static string newtype;
        public AddNewType()
        {
            InitializeComponent();
        }
        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            newtype = newType.Text;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
