using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DorsetCollegeOnlineStore.Models;

public class Cart
{
    public int Id { get; set; }
    public int UserId { get; set; }
}