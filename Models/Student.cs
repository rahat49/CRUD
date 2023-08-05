using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDwithAngular.Models
{
    public class Student
    {
        [Key] 
        public int Id { get; set; }
        [DisplayName("Student Name")]
        public string stname { get; set; }
        public string Course { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
