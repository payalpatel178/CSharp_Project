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
    /// Interaction logic for AddBlockStockForm.xaml
    /// </summary>
    public partial class AddBlockStockForm : Window
    {
        BloodStock bs = new BloodStock();
        BloodBankDBEntities bloodBankDBEntities = new BloodBankDBEntities();
        private int id = -1;
        public AddBlockStockForm()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        //When user click on save button, it comes here
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //service
            services.BloodStockService service = new services.BloodStockService();
            string bgroup = (cmbBloodGroup.SelectedItem as ComboBoxItem).Content.ToString();

            //storing all the textbox info into onject
            BloodStock bloodstock = new BloodStock()
            {
                bloodBank = txtBloodBankName.Text,
                bloodGroup = bgroup,
                numberOfBottles = Int32.Parse(txtNoOfBottles.Text),
                city = txtCity.Text,
                phoneNo = txtPhone.Text
            };

            //call to service method and passing the object
            int result = service.AddBloodStock(bloodstock);

            //Display Messagebox after success
            MessageBox.Show("New Blood Stock Information added successfully", "Add Blood Stock", MessageBoxButton.OK, MessageBoxImage.Information);
            
            //call to reset the whole form
            btnReset_Click(sender, e);

        }

        //Function to reset all the textbox and combobox
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtBloodBankName.Clear();
            cmbBloodGroup.SelectedIndex = 0;
            txtNoOfBottles.Clear();
            txtCity.Clear();
            txtPhone.Clear();
        }

        //When user clicks on update it comes here,
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string bgroup = (cmbBloodGroup.SelectedItem as ComboBoxItem).Content.ToString();

            //getting object of the information to be updated from id
            BloodStock bStock = bloodBankDBEntities.BloodStocks.Single(bs => bs.bloodStockId == id);
            
            //storing all the info into object
            bStock.bloodBank = txtBloodBankName.Text;
            bStock.bloodGroup = bgroup;
            bStock.numberOfBottles = Int32.Parse(txtNoOfBottles.Text);
            bStock.city = txtCity.Text;
            bStock.phoneNo = txtPhone.Text;

            //saving the changes
            bloodBankDBEntities.SaveChanges();

            //displaying message to user
            MessageBox.Show("Blood Stock Information Updated successfully", "Update Blood Stock", MessageBoxButton.OK, MessageBoxImage.Information);
            //closing the form
            this.Close();
        }

        //when user redirected from blood stock page to display upadte form
        internal void UpdateShow(int bId)
        {
            id = bId;
            //getting selected row data from database depends on id
            var query = from bloodStock in bloodBankDBEntities.BloodStocks
                        where bloodStock.bloodStockId == bId
                        select new { bloodStock.bloodStockId, bloodStock.bloodBank, bloodStock.bloodGroup, bloodStock.numberOfBottles, bloodStock.city, bloodStock.phoneNo };

            //storing database data into textboxes and combobox
            txtBloodBankName.Text = query.FirstOrDefault().bloodBank;
            (cmbBloodGroup.SelectedItem as ComboBoxItem).Content= query.FirstOrDefault().bloodGroup;
            txtNoOfBottles.Text = query.FirstOrDefault().numberOfBottles.ToString();
            txtCity.Text = query.FirstOrDefault().city;
            txtPhone.Text = query.FirstOrDefault().phoneNo;

            //displaying the form with all the information filled in
            base.Show();
        }
    }
}
