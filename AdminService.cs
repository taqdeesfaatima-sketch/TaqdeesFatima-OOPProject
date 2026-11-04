using Project.Admin;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Admin
{
    public class AdminService
    {
        private readonly AdminRepository _repository;
        public AdminService()
        {
            _repository = new AdminRepository();

        }
        public void addproduct(AdminModel product)
        {
            _repository.Save(product);
        }
        public AdminModel findproductbyname(string name)
        {
            var products = _repository.GetAll();
            foreach (var product in products)
            {
                if (product.productName == name)
                {
                    return product;
                }
            }
            return null;
        }
        public bool deleteproductbyname(string name)
        {
            var products = _repository.GetAll();
            AdminModel producttodelete = null;
            foreach (var product in products)
            {
                if (product.productName == name)
                {
                    producttodelete = product;
                    break;
                }
            }
            if (producttodelete != null)
            {
                products.Remove(producttodelete);
                _repository.SaveAll(products);
                return true;
            }
            return false;
        }

        public List<AdminModel> getallproducts()
        {
            return _repository.GetAll();
        }
        public void clearallproducts()
        {
            _repository.ClearAll();
        }
        public List<AdminModel>CorrectProductPlace(string Correctplace)
        {
            var Products = _repository.GetAll();
            List<AdminModel> products = new List<AdminModel>();
            foreach (var product in Products)
            {

                if (product.productName == Correctplace)
                {
                    product.productName = Correctplace;
                }
                return products;
            }
            return null;
        }      
        
        public List<AdminModel>filterProductCategory(string category)
        {
            var  Products = _repository.GetAll();
            List<AdminModel> filteredproducts = new List<AdminModel>();
            foreach (var product in Products)
            {
                if (product.category == category)
                {
                    product.category = category;
                }
                return filteredproducts;
            }
            return null;
        }
    }
}