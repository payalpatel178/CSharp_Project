using BloodBankWPFApplication;

namespace services
{
    public class DonorService
    {
        //method to add new donor info
        public int AddDonor(DonorDetail donor)
        {
            using (var bbContext = new BloodBankDBEntities())
            {
                bbContext.DonorDetails.Add(donor);
                bbContext.SaveChanges();
            }
            return 0;
        }
        //method to add new donor address info
        //return id stored info
        public int AddDonorAddress(Address address)
        {
            using (var bbContext = new BloodBankDBEntities())
            {
                bbContext.Addresses.Add(address);
                bbContext.SaveChanges();
            }
            return address.addressId;
        }
    }
}