using BloodBankWPFApplication;

namespace services
{
    internal class BloodRequestPatientService
    {
        BloodBankDBEntities bloodBankDBEntities = new BloodBankDBEntities();

        //method to add new patient details
        public int AddPatient(BloodRequestPatientDetail patient)
        {
            using (var bbContext = new BloodBankDBEntities())
            {
                bbContext.BloodRequestPatientDetails.Add(patient);
                bbContext.SaveChanges();
            }
            return 0;
        }
        //method to address hospital address info
        //return id of stored info
        public int AddHospitalAddress(Address address)
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