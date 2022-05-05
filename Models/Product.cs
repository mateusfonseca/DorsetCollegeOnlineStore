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

using System.ComponentModel.DataAnnotations.Schema;

namespace DorsetCollegeOnlineStore.Models;

public class Product
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [Column(TypeName = "decimal(18, 2)")] public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public string? Image { get; set; }
    public double? Rate { get; set; }
    public int? Count { get; set; }
}