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

namespace DorsetCollegeOnlineStore.Models;

public static class Session
{
    public static int? UserId { get; set; }

    static Session()
    {
        UserId = null;
    }
}