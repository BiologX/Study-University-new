namespace StoreOnline.Core.Models
{
    public class Delivery
    {
        public Guid Id { get; set; }
        public string Adress { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }

        private Delivery(Guid id, string adress, string status, DateTime createdDate)
        {
            Id = id;
            Adress = adress;
            this.status = status;
            CreatedDate = createdDate;
        }

        public static Delivery Create(Guid id, string adress, string status, DateTime createdDate)
        {
            return new Delivery(id, adress, status, createdDate);
        }
    }
}
