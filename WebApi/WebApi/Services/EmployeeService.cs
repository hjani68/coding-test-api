using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeModel>> GetAllEmployee();
    }
    public class EmployeeService : IEmployeeService
    {
        public async Task<List<EmployeeModel>> GetAllEmployee()
        {
            var employeeList = new List<EmployeeModel>();
            employeeList.Add(new EmployeeModel { EmployeeId = 1, FirstName = "Hardik", LastName = "Jani", EmailAddress = "test@test.com", PhoneNumber = "0123456789" });
            employeeList.Add(new EmployeeModel { EmployeeId = 2, FirstName = "John", LastName = "Abhra", EmailAddress = "test@test.com", PhoneNumber = "0123456789" });
            employeeList.Add(new EmployeeModel { EmployeeId = 3, FirstName = "Kevin", LastName = "Kohli", EmailAddress = "test@test.com", PhoneNumber = "0123456789" });
            employeeList.Add(new EmployeeModel { EmployeeId = 4, FirstName = "Ricky", LastName = "Pointing", EmailAddress = "test@test.com", PhoneNumber = "0123456789" });
            employeeList.Add(new EmployeeModel { EmployeeId = 5, FirstName = "Daniel", LastName = "George", EmailAddress = "test@test.com", PhoneNumber = "0123456789" });
            employeeList.Add(new EmployeeModel { EmployeeId = 6, FirstName = "Tomie", LastName = "Phanny", EmailAddress = "test@test.com", PhoneNumber = "0123456789" });
            employeeList.Add(new EmployeeModel { EmployeeId = 7, FirstName = "Sam", LastName = "Houston", EmailAddress = "test@test.com", PhoneNumber = "0123456789" });
            employeeList.Add(new EmployeeModel { EmployeeId = 8, FirstName = "Divi", LastName = "Johny", EmailAddress = "test@test.com", PhoneNumber = "0123456789" });
            employeeList.Add(new EmployeeModel { EmployeeId = 9, FirstName = "Dominic", LastName = "Cooper", EmailAddress = "test@test.com", PhoneNumber = "0123456789" });
            employeeList.Add(new EmployeeModel { EmployeeId = 10, FirstName = "Peter", LastName = "Pan", EmailAddress = "test@test.com", PhoneNumber = "0123456789" });

            return employeeList;
        }
    }
}
