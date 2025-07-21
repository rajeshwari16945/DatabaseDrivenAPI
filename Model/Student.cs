using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseDrivenAPI.Model
{
    [Table("student")]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

    }
}
