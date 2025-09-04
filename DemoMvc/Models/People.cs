using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
    [Table("People")]
public class People
{
    [Key]
    public required String PeopleID { get; set; }
    public required String FullName { get; set; }
    public required String Address { get; set; }
    }
}