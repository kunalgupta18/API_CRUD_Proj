using API1.Models;
using API1.Repositry.interfaces;
using API1.Services.Interfaces;

namespace API1.Services
{
    public class CustomerServiceImp : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerServiceImp(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public List<Customer> GetCustomers()
        {
            return _customerRepo.GetCustomers();
        }

        public Customer GetCustomerById(string id)
        {
            return _customerRepo.GetCustomerById(id);
        }

        public Customer CreateCustomer(string id, string companyName, string contactName)
        {
            var customer = MapCustomerDTOToCustomerCreate(id, companyName, contactName);
            return _customerRepo.CreateCustomer(customer);
        }

        public Customer UpdateCustomer(string id, string companyName, string contactName)
        {
            var customer = MapCustomerDTOToCustomerUpdate(id, companyName, contactName);
            return _customerRepo.UpdateCustomer(customer);
        }

        public bool DeleteCustomer(string id)
        {
            return _customerRepo.DeleteCustomer(id);
        }

        private static Customer MapCustomerDTOToCustomerCreate(string id, string companyName, string contactName)
        {
            return new Customer
            {
                CustomerID = id,
                CompanyName = companyName,
                ContactName = contactName
            };
        }
        private static Customer MapCustomerDTOToCustomerUpdate(string id, string companyName, string contactName)
        {
            return new Customer
            {
                CustomerID = id,
                CompanyName = companyName, 
                ContactName = contactName
            };
        }
    }
}