using System;

public partial class RegisterPage : System.Web.UI.Page
{
    private int EventId
    {
        get
        {
            int id;
            int.TryParse(Request.QueryString["eventId"], out id);
            return id;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && EventRepository.GetById(EventId) == null)
            Response.Redirect("Home.aspx");
    }

    protected void cvTerms_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
    {
        args.IsValid = chkTerms.Checked;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!Page.IsValid) return;

        var reg = new Registration
        {
            EventId = EventId,
            Name = txtName.Text.Trim(),
            Email = txtEmail.Text.Trim(),
            TicketType = rblTicket.SelectedValue,
            City = ddlCity.SelectedValue,
            Timestamp = DateTime.Now
        };
        RegistrationService.AddRegistration(reg);

        CookieHelper.WriteCookie("EventLite_Name", reg.Name);
        CookieHelper.WriteCookie("EventLite_Email", reg.Email);

        Response.Redirect("Confirm.aspx");
    }
}
