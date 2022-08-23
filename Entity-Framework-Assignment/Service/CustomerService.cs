using Entity_Framework_Assignment.Entity;
using Entity_Framework_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Assignment.Service
{
    public interface ICustomerService
    {
        public  IEnumerable<Customer> GetAll();
        public  Task<Customer> Add(Customer obj);
        public Customer GetById(int Id);
        public Customer UpdateData(Customer obj);

        public Customer Delete(int Id);
    }
    public class CustomerService : ICustomerService
    {
        private readonly CoreDbContext CustomerContext;
        public CustomerService(CoreDbContext _CustomerContext)
        {
            CustomerContext = _CustomerContext;
        }

        public async Task<Customer> Add(Customer obj)
        {
            var AddData = await CustomerContext.CustomerTable.AddAsync(obj);
            CustomerContext.SaveChanges();
            return AddData.Entity;
        }

        public Customer Delete(int Id)
        {
            var DeleteData = CustomerContext.CustomerTable.FirstOrDefault(obj => obj.Id == Id);
            if (DeleteData != null)
            {
                var Deleted = CustomerContext.CustomerTable.Remove(DeleteData);
                CustomerContext.SaveChanges();
                return Deleted.Entity;
            }
            else
            {
                return DeleteData;
            }

        }

        public  IEnumerable<Customer> GetAll()
        {
            var GetAllData =  CustomerContext.CustomerTable.ToList();
            
            return  GetAllData;
        }

        public Customer GetById(int Id)
        {
            var DataById = CustomerContext.CustomerTable.FirstOrDefault(obj => obj.Id == Id);
            CustomerContext.SaveChanges();
                return DataById;
        }

        public  Customer UpdateData(Customer obj)
        {
            var DataUpdate =  CustomerContext.CustomerTable.FirstOrDefault(obj => obj.Id == obj.Id);
            if(DataUpdate != null)
            {
                DataUpdate.FirstName = obj.FirstName;
                DataUpdate.LastName = obj.LastName;
                DataUpdate.Email = obj.Email;
                DataUpdate.Address = obj.Address;
                DataUpdate.Phone = obj.Phone;
                var Updated =  CustomerContext.CustomerTable.Update(DataUpdate);
                CustomerContext.SaveChanges();
                return Updated.Entity;
            }
            else
            {
                return DataUpdate;
            }
        }
    }
}
