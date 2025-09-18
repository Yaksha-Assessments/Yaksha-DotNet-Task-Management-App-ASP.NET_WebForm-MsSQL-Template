using System;
using System.Linq;

public partial class ConfirmPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;

        var name = CookieHelper.ReadCookie("EventLite_Name");
        if (string.IsNullOrWhiteSpace(name))
        {
            var latest = RegistrationService.GetUserRegistrations().LastOrDefault();
            name = latest != null ? latest.Name : "Guest";
        }
        lblName.Text = name;

        lblTotal.Text = RegistrationService.GetTotalRegistrations().ToString();
    }
}
