using System;
using System.ComponentModel;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
    }
}