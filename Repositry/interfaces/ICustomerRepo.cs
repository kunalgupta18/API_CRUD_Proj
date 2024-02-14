using API1.Models;
using System.Collections.Generic;

namespace API1.Repositry.interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(string id);
        Customer CreateCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        bool DeleteCustomer(string id);
    }
}