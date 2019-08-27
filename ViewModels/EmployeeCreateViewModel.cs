using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace EmployeeManagement.ViewModels
{
public class EmployeeCreateViewModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public IFormFile Photo { get; set; }
}
}