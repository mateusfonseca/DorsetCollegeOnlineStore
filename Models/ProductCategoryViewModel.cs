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

using Microsoft.AspNetCore.Mvc.Rendering;

namespace DorsetCollegeOnlineStore.Models;

public class ProductCategoryViewModel
{
    public List<Product>? Products { get; set; }
    public SelectList? Categories { get; set; }
    public string? ProductCategory { get; set; }
    public string? SearchString { get; set; }
}