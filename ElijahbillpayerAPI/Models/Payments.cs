namespace ElijahbillpayerAPI.Models
{
    public class Payments
    {
        //here is the model contains every payment made in the web platform
        public int ID { get; set; }
        public string? PaymentID { get; set; }
        public string? Userid { get; set; }
        public string? PaymentDate { get; set; }
        public string? Amount { get; set; }
        public string? Billid{ get; set; }
        public string? Status { get; set; }
    }
}
