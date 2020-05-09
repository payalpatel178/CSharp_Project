using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for SearchBloodForm.xaml
    /// </summary>
    public partial class SearchBloodForm : Window
    {
        BloodBankDBEntities bloodBankDBEntities = new BloodBankDBEntities();
        public SearchBloodForm()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        //when window load it fetches the data from two table through join
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from d in bloodBankDBEntities.DonorDetails
                        join a in bloodBankDBEntities.Addresses
                        on d.addressId equals a.addressId
                        //where
                        select new { d.firstName, d.bloodGroup, a.province, a.city, d.phoneNo };
            //display the returned data list into datagrid
            this.DataContext = query.ToList();
        }
        //all the events to hide current form and display respective form
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegisterAsDonorForm radf = new RegisterAsDonorForm();
            radf.Show();
        }

        private void btnBloodStock_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BloodStock bs = new BloodStock();
            bs.Show();
        }

        private void btnRequestBlood_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BloodRequest br = new BloodRequest();
            br.Show();
        }

        //when user wants to search for donors of particular  blood group
        private void btnSearchBloodGroup_Click(object sender, RoutedEventArgs e)
        {
            //get selected value of combox
            var sb = (cmbSearchBG.SelectedItem as ComboBoxItem).Content.ToString();
            //if it is all display entire list
            if (sb.Equals("All"))
            {
               Window_Loaded(sender, e);
            }
            //else fetch data for that selected blood group
            else
            {
                var query = from d in bloodBankDBEntities.DonorDetails
                            join a in bloodBankDBEntities.Addresses
                            on d.addressId equals a.addressId
                            where d.bloodGroup == sb
                            select new { d.firstName, d.bloodGroup, a.province, a.city, d.phoneNo };
                //if it does not found any match
                if (query.ToList().Count == 0)
                {
                    //display message and show entire list
                    MessageBox.Show($"Data for given {sb} blood group are not available", "Search Result", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    cmbSearchBG.Text="All";
                    Window_Loaded(sender, e);
                }
                //else display returned data
                else
                {
                    this.DataContext = query.ToList();
                }

            }
        }
    }
}
