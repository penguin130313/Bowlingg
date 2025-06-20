using System.ComponentModel.DataAnnotations;
namespace Bowling.DAL;

public class Client
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public double Phone{ get; set; }
}
