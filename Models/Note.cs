using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTR02.Models
{
    public class Note
    {
        [Key]
        public int NoteID { get; set; }
        [Required]
        [StringLength(64)]
        public string Title { get; set; }
        [StringLength(int.MaxValue)]
        public string Descriptor { get; set; }
        [StringLength(int.MaxValue)]
        public string Content { get; set;}
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [NotMapped]
        public bool isDisplayable {get;set;}
    }
}
