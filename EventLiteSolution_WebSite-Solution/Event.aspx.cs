using System;

public partial class EventPage : System.Web.UI.Page
{
    private int EventId
    {
        get
        {
            int.TryParse(Request.QueryString["eventId"], out var id);
            return id;
        }
    }

    private int Seats
    {
        get { return (int)(ViewState["Seats"] ?? 1); }
        set { ViewState["Seats"] = value < 1 ? 1 : value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var ev = EventRepository.GetById(EventId);
            if (ev == null) { Response.Redirect("Home.aspx"); return; }

            lblTitle.Text = ev.Title;
            lblDate.Text = ev.Date.ToString("dd-MMM-yyyy");
            lblFee.Text  = ev.Fee.ToString("C");
            lblDesc.Text = ev.Description;

            hfNonce.Value = Guid.NewGuid().ToString();
            Seats = 1;
            lblSeats.Text = $"Seats: {Seats}";
        }
    }

    protected void btnMinus_Click(object sender, EventArgs e)
    {
        Seats -= 1;
        lblSeats.Text = $"Seats: {Seats}";
    }

    protected void btnPlus_Click(object sender, EventArgs e)
    {
        Seats += 1;
        lblSeats.Text = $"Seats: {Seats}";
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect($"Register.aspx?eventId={EventId}");
    }
}
