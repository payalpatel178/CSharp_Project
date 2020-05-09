using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
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
    /// Interaction logic for BloodStock.xaml
    /// </summary>
    public partial class BloodStock : Window
    {
        //data context
        BloodBankDBEntities bloodBankDBEntities = new BloodBankDBEntities();
       
        public BloodStock()
        {
            InitializeComponent();
            //centering the screen
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        //when window load it fetches all the data from database blood stock table
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from bloodStock in bloodBankDBEntities.BloodStocks
                            //where
                        select new {bloodStock.bloodStockId, bloodStock.bloodBank, bloodStock.bloodGroup, bloodStock.numberOfBottles, bloodStock.city, bloodStock.phoneNo };
            //fill the datagrid with returned data
            bloodStockDataGrid.ItemsSource = query.ToList();

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

        private void btnRequestBlood_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BloodRequest br = new BloodRequest();
            br.Show();
        }

        //CRUD Operation
        //Create, Read, Update And Delete
        //when user wants to add new blood stock info
        private void btnAddBlockStock_Click(object sender, RoutedEventArgs e)
        {
            AddBlockStockForm absf = new AddBlockStockForm();
            absf.btnUpdate.Visibility = Visibility.Hidden;
            absf.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            var query = from bloodStock in bloodBankDBEntities.BloodStocks
                            //where
                        select new { bloodStock.bloodStockId, bloodStock.bloodBank, bloodStock.bloodGroup, bloodStock.numberOfBottles, bloodStock.city, bloodStock.phoneNo };
            //this.DataContext = query.ToList();
            bloodStockDataGrid.ItemsSource = query.ToList();
        }

        //when user wants to delete particular data
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string selectedId = "";
            //checking user has selected the row to be deleted
            //else display error message
            if (bloodStockDataGrid.SelectedIndex != -1)
            {
                //getting id
                DataGrid dataGrid = sender as DataGrid;
                DataGridRow row = (DataGridRow)bloodStockDataGrid.ItemContainerGenerator.ContainerFromIndex(bloodStockDataGrid.SelectedIndex);
                DataGridCell RowColumn = bloodStockDataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
                selectedId = ((TextBlock)RowColumn.Content).Text;

                int bId = Int32.Parse(selectedId);
                //fetching data for particular id
                var bs = (from r in bloodBankDBEntities.BloodStocks
                          where r.bloodStockId == bId
                          select r).SingleOrDefault();
                //Removing data
                bloodBankDBEntities.BloodStocks.Remove(bs);
                //saving the changes
                bloodBankDBEntities.SaveChanges();
                //Display message on success
                MessageBox.Show("Selected Information deleted successfully", "Result", MessageBoxButton.OK, MessageBoxImage.Information);
                //Refreshing datagrid
                bloodStockDataGrid.ItemsSource = bloodBankDBEntities.BloodStocks.ToList();
            }
            else
            {
                MessageBox.Show("Please Select any Row to Delete", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        //when user wants to upadte any data
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string selectedId = "";
            //checking user has selected the row to be updated
            //else display error message
            if (bloodStockDataGrid.SelectedIndex != -1)
            {
                //getting id
                DataGrid dataGrid = sender as DataGrid;
                DataGridRow row = (DataGridRow)bloodStockDataGrid.ItemContainerGenerator.ContainerFromIndex(bloodStockDataGrid.SelectedIndex);
                DataGridCell RowColumn = bloodStockDataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
                selectedId = ((TextBlock)RowColumn.Content).Text;

                int bId = Int32.Parse(selectedId);

                //creating object for update form
                AddBlockStockForm ab = new AddBlockStockForm();
                ab.btnSave.Visibility = Visibility.Hidden;
                //call to update form and passing id
                ab.UpdateShow(bId);
            }
            else
            {
                MessageBox.Show("Please Select any Row to Update", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
