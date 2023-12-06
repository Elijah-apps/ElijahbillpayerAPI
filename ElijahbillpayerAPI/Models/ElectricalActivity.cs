namespace ElijahbillpayerAPI.Models
{
    public class ElectricalActivity
    {
        //here is the model that controls all electrical activity
        public int ID { get; set; }
        public string? NepaID { get; set; }
        public string? UserID { get; set; }
        public string? MetreNo { get; set; }
        public string? Amount { get; set; }
        public string? DateTime { get; set; }
        public string? Status { get; set; }
    }
}
