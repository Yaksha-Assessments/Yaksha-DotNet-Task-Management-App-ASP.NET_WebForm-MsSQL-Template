using System.Collections.Generic;
using System.Web;

public static class RegistrationService
{
    private const string SessionKey = "EventLite_Registrations";

    public static List<Registration> GetUserRegistrations()
    {
        var ctx = HttpContext.Current;
        if (ctx.Session[SessionKey] == null)
            ctx.Session[SessionKey] = new List<Registration>();
        return (List<Registration>)ctx.Session[SessionKey];
    }

    public static void AddRegistration(Registration reg)
    {
        GetUserRegistrations().Add(reg);
        var app = HttpContext.Current.Application;
        app.Lock();
        app["TotalRegistrations"] = ((int)app["TotalRegistrations"]) + 1;
        app.UnLock();
    }

    public static int GetTotalRegistrations()
    {
        return (int)(HttpContext.Current.Application["TotalRegistrations"] ?? 0);
    }
}
