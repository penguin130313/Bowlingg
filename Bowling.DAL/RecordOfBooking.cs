using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Bowling.DAL;

public class RecordOfBooking
{
    [Key] public int Id { get; set; }
    public int? ClientId { get; set; }
    [ForeignKey("ClientId")]public Client? Client { get; set; }
    public int? TrackId { get; set; }
    [ForeignKey("TrackId")]public Track? Track { get; set; }
    public int? BookingId { get; set; }
    [ForeignKey("BookingId")]public Booking? Booking { get; set; }
   
    public DateTime DateOfRecord  { get; set; } = DateTime.Today;
    
    public DateTime TimeOfRecord { get; set; } = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day, 10,00, 0 );

}