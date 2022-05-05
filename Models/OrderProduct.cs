using System.ComponentModel.DataAnnotations.Schema;
using MessagePack;

namespace DorsetCollegeOnlineStore.Models;

public class OrderProduct
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}