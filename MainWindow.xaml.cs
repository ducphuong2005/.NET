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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TH2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_XacNhan(object sender, RoutedEventArgs e)
        {
            string iD= id.Text.Trim();
            string Name= name.Text.Trim();
            double Salary =double.Parse(salary.Text.Trim());
            double Gift = Salary * 0.1;
            gift.Text = Gift.ToString();
            if(Salary >1000 || Salary<100)
            {
                MessageBox.Show("Nhap luong tu 100 den 1000 thoi");
                return;
            }
            if(string.IsNullOrEmpty(id.Text) || string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(salary.Text) || comboBox.SelectedItem==null || (!gender0.IsChecked.Value&&!gender1.IsChecked.Value))
            {
                MessageBox.Show("Nhap day du thong tin di", "Thong bao");
                return;
            }

        }

        private void Button_Xoa(object sender, RoutedEventArgs e)
        {
            id.Text = "";
            name.Text = "";
            salary.Text = "";
            gift.Text = "";
        }
    }
}
