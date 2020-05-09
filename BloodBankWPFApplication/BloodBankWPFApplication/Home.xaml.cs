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

namespace BloodBankWPFApplication
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        //all the events to hide current form and display respective form
        //Hide the current form and display Add Register form
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegisterAsDonorForm radf = new RegisterAsDonorForm();
            radf.Show();
        }
        //Hide the current form and display Search blood form
        private void btnSearchBlood_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchBloodForm sbf = new SearchBloodForm();
            sbf.Show();
        }
        //Hide the current form and display Blood Stock form
        private void btnBloodStock_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BloodStock bs = new BloodStock();
            bs.Show();
        }
        //Hide the current form and display Request blood form
        private void btnRequestBlood_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BloodRequest br = new BloodRequest();
            br.Show();
        }
    }
}
