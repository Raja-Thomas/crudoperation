using razorpages.Models;
using System.Collections.Generic;

namespace razorpages.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        List<Cars> GetAll();
    }
}