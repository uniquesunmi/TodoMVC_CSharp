using System.ComponentModel.DataAnnotations;

namespace TodoMVC_CSharp.Models
{
    public class Todo

    {
        [Key]
        public int Id { get; set; }
     
        [StringLength(50)]
        public required string Title { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }
    }

}
