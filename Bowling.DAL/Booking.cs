using System.ComponentModel.DataAnnotations;
namespace Bowling.DAL;

public class Booking
{
    [Key] public int Id { get; set; }
    public int ClientId { get; set; }
    public int TrackId { get; set; }
    public DateTime BookingDate { get; set; }
    public bool IsPayment { get; set; }
}