using System.ComponentModel.DataAnnotations.Schema;
using MessagePack;

namespace DorsetCollegeOnlineStore.Models;

public class CartProduct
{
    public int Id { get; set; }
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}