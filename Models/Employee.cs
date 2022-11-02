using System.ComponentModel.DataAnnotations;

namespace LeAnhTuanBTH2.Models

{
    public class Employee
    {
        [Key]
        public string? EmpID { get; set; }
        public string? EmpName { get; set; }
        public String? Address { get; set; }
    }
}