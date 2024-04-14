namespace simpletest.Models;
using System.ComponentModel.DataAnnotations;

public class Course{
    [Key]
    public int Id { get; set; }

    [Required (ErrorMessage= "Required element Name")]
    [MaxLength(30, ErrorMessage= "Max length is 30")]
    [MinLength(3, ErrorMessage= "Min length is 3")]
    public string Name { get; set; }

    [MaxLength(1024, ErrorMessage= "Max length is 1024")]
    public string? Description { get; set; }

    [Required (ErrorMessage= "Required element Price")]
    [Range (1, int.MaxValue, ErrorMessage= "Invalid price")]
    public decimal Price { get; set; }
    public Catagory? Catagory { get; set; }
}