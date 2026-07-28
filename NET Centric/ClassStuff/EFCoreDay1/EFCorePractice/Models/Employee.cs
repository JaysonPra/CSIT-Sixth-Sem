using System.ComponentModel.DataAnnotations;

namespace EFCorePractice.Models;

public class Employee
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; } 
}