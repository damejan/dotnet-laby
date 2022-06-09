using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace noteApp.Entities;

public class Note
{
    [Key]
    public int Id { get; set; }

    [Required]
    [DisplayName("title")]
    public string title { get; set; }
    
    [Required]
    [DisplayName("description")]
    public string description { get; set; }
}