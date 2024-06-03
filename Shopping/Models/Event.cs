namespace Shopping.Models
{
    public class Event
    {
        public int Id { get; set; }
        public int CampaingId { get; set; }
        public int ShoppingId { get; set; }
        public DateTime? DateEvent { get; set; }
        public int DestinyType { get; set; }
        public int State { get; set; }

    }
}
