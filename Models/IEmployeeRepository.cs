using System;
using System.ComponentModel;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{


public interface IEmployeeRepository
{
    Employee GetEmployee(int Id);
    IEnumerable<Employee> GetAllEmployee();
    Employee Add(Employee employee);
    Employee Update(Employee employeeChanges);
    Employee Delete(int Id);
}
}