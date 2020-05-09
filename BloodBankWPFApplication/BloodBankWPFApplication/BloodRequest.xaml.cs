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
    /// Interaction logic for BloodRequest.xaml
    /// </summary>
    public partial class BloodRequest : Window
    {
        public BloodRequest()
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
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegisterAsDonorForm radf = new RegisterAsDonorForm();
            radf.Show();
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

        //after filling all the required info when user clicks on send request button, it comes here
        private void btnSendRequest_Click(object sender, RoutedEventArgs e)
        {
            //service object
            services.BloodRequestPatientService service = new services.BloodRequestPatientService();

            //address object
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
            //storing address info in address table and returning id of stored info
            int addId = service.AddHospitalAddress(address);


            string pbgroup = (cmbPatientBloodGroup.SelectedItem as ComboBoxItem).Content.ToString();

            //storing patients personal info in to object
            BloodRequestPatientDetail patient = new BloodRequestPatientDetail()
            {
                firstName = txtPatientFirstName.Text,
                lastName = txtPatientLastName.Text,
                bloodGroup = pbgroup,
                age = Int32.Parse(txtPatientAge.Text),
                bloodUnit = Int32.Parse(txtBloodUnit.Text),
                reasonOfNeed=txtNeed.Text,
                purpose=txtPurpose.Text,
                phoneNo = txtPhone.Text,
                hospital = txtHospital.Text,
                addressId = addId
            };

            //call to service method and passing object
            int result = service.AddPatient(patient);

            //display message after success
            MessageBox.Show("Blood request sended successfully", "Registration", MessageBoxButton.OK, MessageBoxImage.Information);
            //call to method to clear the form data
            btnReset_Click(sender, e);
        }

        //method to clear form data
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtPatientFirstName.Clear();
            txtPatientLastName.Clear();
            cmbPatientBloodGroup.SelectedIndex = 0;
            txtPatientAge.Clear();
            txtBloodUnit.Clear();
            txtNeed.Clear();
            txtPurpose.Clear();
            txtPhone.Clear();
            txtHospital.Clear();
            txtStreetNumber.Clear();
            txtStreetName.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtCountry.Clear();
            txtPostalCode.Clear();
        }
    }
}
