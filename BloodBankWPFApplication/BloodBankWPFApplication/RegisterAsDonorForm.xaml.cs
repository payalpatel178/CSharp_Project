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
    /// Interaction logic for RegisterAsDonorForm.xaml
    /// </summary>
    public partial class RegisterAsDonorForm : Window
    {
        public RegisterAsDonorForm()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        //all the events to hide current form and display respective form
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void btnSearchBlood_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchBloodForm sbf = new SearchBloodForm();
            sbf.Show();
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

        //When user click on register after filling all the info
        private void btnRegisteration_Click(object sender, RoutedEventArgs e)
        {
            //service
            services.DonorService service = new services.DonorService();

            //storing address info into address class object
            Address address = new Address()
            {
                streetNumber = Int32.Parse(txtStreetNumber.Text),
                streetName = txtStreetName.Text,
                city = txtCity.Text,
                province = txtProvince.Text,
                country = txtCountry.Text,
                postalCode = txtPostalCode.Text
            };
            //call to method of service and passing address object
            //returing id
            int addressId= service.AddDonorAddress(address);
            string bgroup = (cmbBloodGroup.SelectedItem as ComboBoxItem).Content.ToString();
            string gender = (rbMale.IsChecked == true) ? "Male" : "Female";

            //storing personal info of donor
            DonorDetail donor = new DonorDetail()
            {
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text,
                bloodGroup = bgroup,
                age = Int32.Parse(txtAge.Text),
                gender = gender,
                addressId = addressId,
                phoneNo = txtPhone.Text,
                email = txtEmail.Text
            };
            //call to method of service and passing donor object
            int result = service.AddDonor(donor);
            //display message on success
            MessageBox.Show("New donor added successfully", "Registration",MessageBoxButton.OK,MessageBoxImage.Information);
            //call to reset method to clear form data
            btnReset_Click(sender,e);
        }

        //event to reset or clear the entire form data
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbBloodGroup.SelectedIndex = 0;
            txtAge.Clear();
            rbMale.IsChecked = true;
            txtPhone.Clear();
            txtEmail.Clear();
            txtStreetNumber.Clear();
            txtStreetName.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtCountry.Clear();
            txtPostalCode.Clear();
        }
    }
}
