using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1,Name="Madan",Department="HR",Email="abc@gmail.com"},
                new Employee() { Id = 2, Name = "Sadan", Department = "IT", Email = "bc@gmail.com" },
                new Employee() { Id = 3, Name = "Ram", Department = "HR", Email = "ac@gmail.com" }

            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e=>e.Id==Id);
    
        }
    }
}
