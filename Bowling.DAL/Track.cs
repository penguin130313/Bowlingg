using System.ComponentModel.DataAnnotations;
namespace Bowling.DAL;

public class Track
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string IsAvailable { get; set; }
}
