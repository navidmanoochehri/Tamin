using Tamin.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Tamin.Data
{
    class VendorData : IVendorData
    {
        private readonly ISqlDataAccess _dbVendorData;

        public VendorData(ISqlDataAccess dbVendorData)
        {
            _dbVendorData = dbVendorData;
        }

        public Task<List<VendorInPut>> GetVendors()
        {
            string sql = "SELECT * from dbo.Vendors";
            return _dbVendorData.LoadData<VendorInPut, dynamic>(sql, new { });
        }
        public Task InsertVendors(VendorInPut vendor)
        {
            string sql = @"INSERT into dbo.Vendors (Name, ManagerName, Phone, Address, Fax, MailBox, Email, CheckRegistrationNo, RegistrationNo,CheckEconomicCode,
                         EconomicCode, PostalCode, WebSite, CheckNatioalId, NatioalId, Catalog, HasCooperationResume, CooperationResume, VendorListResume, ActivityDescription,
                         Description, Activities, Date, Groups, Projects, Status, EditDate) Values (@Name, @ManagerName, @Phone, @Address, @Fax, @MailBox, @Email, @CheckRegistrationNo, @RegistrationNo, @CheckEconomicCode,
                         @EconomicCode, @PostalCode, @WebSite, @CheckNatioalId, @NatioalId, @Catalog, @HasCooperationResume, @CooperationResume, @VendorListResume, @ActivityDescription,
                         @Description, @Activities, @Date, @Groups, @Projects, @Status, @EditDate);";
            return _dbVendorData.SaveData(sql, vendor);
        }
        public Task UpdateVendors(VendorInPut vendor)
        {
            string sql = @"UPDATE dbo.Vendors set Name=@Name, ManagerName=@ManagerName, Phone=@Phone, Address=@Address, Fax=@Fax, MailBox=@MailBox, Email=@Email, CheckRegistrationNo=@CheckRegistrationNo, RegistrationNo=@RegistrationNo, CheckEconomicCode=@CheckEconomicCode,
                         EconomicCode=@EconomicCode, PostalCode=@PostalCode, WebSite=@WebSite, CheckNatioalId=@CheckNatioalId, NatioalId=@NatioalId, Catalog=@Catalog, HasCooperationResume=@HasCooperationResume, CooperationResume=@CooperationResume, VendorListResume=@VendorListResume, ActivityDescription=@ActivityDescription,
                         Description=@Description, Activities=@Activities, Date=@Date, Groups=@Groups, Projects=@Projects, Status=@Status, EditDate=@EditDate WHERE Id=@Id";
            return _dbVendorData.SaveData(sql, vendor);
        }
        public Task DeleteVendores(VendorInPut vendor)
        {
            string sql = @"DELETE dbo.Vendors WHERE Id=@Id";
            return _dbVendorData.SaveData(sql, vendor);
        }
    
    }
}
