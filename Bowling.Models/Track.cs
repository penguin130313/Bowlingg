using System.ComponentModel.DataAnnotations;

namespace Bowling.Models;

public partial class Track
{
    [Key] public int Id { get; set; }
    public string TrackName { get; set; }
    public string IsAvailable { get; set; }
    public string Amount { get; set; }
 
    
    
}


