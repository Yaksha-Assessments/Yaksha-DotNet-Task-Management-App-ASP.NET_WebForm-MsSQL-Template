using System;
using System.Web;

public partial class Global : HttpApplication
{
    protected void Application_Start(object sender, EventArgs e)
    {
        EventRepository.Seed();
        Application["TotalRegistrations"] = 0;
    }
}
