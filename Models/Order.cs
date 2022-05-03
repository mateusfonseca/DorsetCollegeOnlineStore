using System.ComponentModel.DataAnnotations;

namespace DorsetCollegeOnlineStore.Models;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    // public List<int>? ProductId { get; set; }
    // public List<int>? ProductQuantity { get; set; }
}