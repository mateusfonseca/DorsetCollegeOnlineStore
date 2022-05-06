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

using System.ComponentModel.DataAnnotations;

namespace DorsetCollegeOnlineStore.Models;

public class User
{
    public int Id { get; set; }

    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Letters only!")]
    public string? FirstName { get; set; }

    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Letters only!")]
    public string? LastName { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email address!")]
    public string? Email { get; set; }

    [RegularExpression(@"^[0-9]+((\-)?[0-9]+)*$", ErrorMessage = "Numbers and hyphens only!")]
    public string? PhoneNumber { get; set; }

    public string? Password { get; set; }
    public string? Image { get; set; }

    public User()
    {
        Image = "https://thispersondoesnotexist.com/image";
    }
}