using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bowling.Models;

public class Payment
{
    [Key] public int Id { get; set; }
    public int TrackId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Time { get; set; }
    [ForeignKey("TrackId")] public  Track Track { get; set; }
    
}