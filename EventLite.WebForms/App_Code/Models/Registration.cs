namespace EventLite.WebForms.Models
{
    public class Registration
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TicketType { get; set; }
        public string City { get; set; }
        public System.DateTime Timestamp { get; set; }
    }
}