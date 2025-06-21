using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Bowling.Models;

public class Booking
{
    [Key] public int Id { get; set; }
    public int? ClientId { get; set; }
    [ForeignKey("ClientId")]public Client? Client { get; set; }
    public int? TrackId { get; set; }
    [ForeignKey("TrackId")]public Track? Track { get; set; }
    public int? BookingId { get; set; }
    [ForeignKey("PaymentId")]public Payment? Payment { get; set; }
   
    public DateTime RecDateTime { get; set; } 
    
    

}