using Entity_Framework_Assignment.Entity;
using Entity_Framework_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Assignment.Service
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAll();
        public Task<Product> Add(Product obj);
        public Product GetById(int Id);
        public Product UpdateData(Product obj);

        public Product Delete(int Id);
    }
    public class ProductService:IProductService
    {
        private readonly CoreDbContext ProductContext;
        public ProductService(CoreDbContext _ProductContext)
        {
            ProductContext = _ProductContext;
        }

        public async Task<Product> Add(Product obj)
        {
            var AddData = await ProductContext.ProductTable.AddAsync(obj);
            ProductContext.SaveChanges();
            return AddData.Entity;
        }

        public Product Delete(int Id)
        {
            var DeleteData = ProductContext.ProductTable.FirstOrDefault(obj => obj.Id == Id);
            if (DeleteData != null)
            {
                var Deleted = ProductContext.ProductTable.Remove(DeleteData);
                ProductContext.SaveChanges();
                return Deleted.Entity;
            }
            else
            {
                return DeleteData;
            }

        }

        public IEnumerable<Product> GetAll()
        {
            var GetAllData = ProductContext.ProductTable.ToList();

            return GetAllData;
        }

        public Product GetById(int Id)
        {
            var DataById = ProductContext.ProductTable.FirstOrDefault(obj => obj.Id == Id);
            ProductContext.SaveChanges();
            return DataById;
        }

        public Product UpdateData(Product obj)
        {
            var DataUpdate = ProductContext.ProductTable.FirstOrDefault(obj => obj.Id == obj.Id);
            if (DataUpdate != null)
            {
                DataUpdate.Name = obj.Name;
                DataUpdate.Price = obj.Price;
                DataUpdate.CustomerId = obj.CustomerId;      
                var Updated = ProductContext.ProductTable.Update(DataUpdate);
                ProductContext.SaveChanges();
                return Updated.Entity;
            }
            else
            {
                return DataUpdate;
            }
        }
    }
}
