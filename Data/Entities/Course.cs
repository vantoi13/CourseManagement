using System.ComponentModel.DataAnnotations;

namespace CourseManagement.Data.Entities;

public class Course
{
    [Required(ErrorMessage = "vui long nhap thong tin")]
    public int Id { get; set; }
    [Required(ErrorMessage = "vui long nhap thong tin")]
    [StringLength(60)]
    public string? Title { get; set; }
    [Required(ErrorMessage = "vui long nhap thong tin")]
    [Display(Name = "Release Date")]
    public string? Topic { get; set; }
    [Required(ErrorMessage = "vui long nhap thong tin")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    [Required(ErrorMessage = "vui long nhap thong tin")]
    [StringLength(60)]
    public string? Author { get; set; }
}