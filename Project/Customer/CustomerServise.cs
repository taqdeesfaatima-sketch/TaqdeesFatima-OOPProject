using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Customer
{
    public class CustomerService
    {
        private readonly CustomerRepository _repository;
        public CustomerService()
        {
            _repository = new CustomerRepository();
        }
        public void addproduct(CustomerModel product)
        {
            _repository.Save(product);
        }

        public CustomerModel FindProductbyName(string name)
        { 
            var products = _repository.GetAll();
            foreach(var product in products)
            {
                if(product.productname==name)
                {
                    return product;
                }
            }
            return null;
        }
        public bool DeleteProductbyName(string name)
        {
            var products = _repository.GetAll();
            CustomerModel producttodelete = null;
            foreach(var product in products )
            {
                if(product.productname==name)
                {
                    producttodelete = product;
                    break;
                }
            }
            if(producttodelete!=null)
            {
                products.Remove(producttodelete);
                _repository.SaveAll(products);
                return true;
            }
            return false;
        }
        public List<CustomerModel>GetAllProducts()
        {
            return _repository.GetAll();
        }
        public void Clearallproducts()
        {
            _repository.ClearAll();
        }
    }
}
