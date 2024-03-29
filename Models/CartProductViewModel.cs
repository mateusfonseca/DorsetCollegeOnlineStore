/*
 Dorset College Dublin
 BSc in Science in Computing & Multimedia
 Object-Oriented Programming - BSC20921
 Stage 2, Semester 2
 Continuous Assessment 2
 
 Student Name: Mateus Fonseca Campos
 Student Number: 24088
 Student Email: 24088@student.dorset-college.ie
 
 Submission date: 8 May 2022
*/

using DorsetCollegeOnlineStore.Controllers;

namespace DorsetCollegeOnlineStore.Models
{
    public class CartProductViewModel
    {
        public int? CartId { get; set; }
        public List<Product>? Products { get; set; }
        public List<int>? ProductsIds { get; set; }
        public Dictionary<int, int>? Quantities { get; set; }
        public Dictionary<int, decimal>? Subtotals { get; set; }
        public decimal? TotalPrice { get; set; }

        public CartProductViewModel()
        {
            CartId = null;
        }
    }
}