using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DorsetCollegeOnlineStore.Models
{
    public class CartProductViewModel
    {
        public int CartId { get; set; }
        public List<Product>? Products { get; set; }
        public List<int>? ProductsIds { get; set; }
        public Dictionary<int, int>? Quantities { get; set; }
        public Dictionary<int, decimal>? Subtotals { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}