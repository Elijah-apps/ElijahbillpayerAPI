namespace ElijahbillpayerAPI.Models
{
    public class AirtimeActivity
    {
        //here is the model that controls all transactions involving airtime
        public int ID { get; set; }
        public string? AirtimeID { get; set; }
        public string? UserID { get; set; }
        public string? ReceiverNo { get; set; }
        public string? Amount { get; set; }
        public string? DateTime { get; set; }
        public string? Status { get; set; }
    }
}
