namespace EventLite.WebForms.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Fee { get; set; }
        public string Description { get; set; }
    }
}