using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace noteApp.Models;

public class NoteModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("title")]
    public string title { get; set; }
    
    [DisplayName("description")]
    public string description { get; set; }
}