using System.ComponentModel.DataAnnotations;
namespace Bowling.DAL;

public class Payment
{
    [Key] public int Id { get; set; }
    public int BookingId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
}