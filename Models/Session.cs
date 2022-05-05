namespace DorsetCollegeOnlineStore.Models;

public static class Session
{
    public static int? UserId { get; set; }

    static Session()
    {
        UserId = 11;
    }
}