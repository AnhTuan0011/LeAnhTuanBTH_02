using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace LeAnhTuanBTH2.Models
{
    public class Student
    {
        //khai bao các thuộc tính 

        [Key]
        [Required(ErrorMessage = "Ma Sinh vien khong duoc de trong")]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public String? Sđt { get; set; }
    }
}