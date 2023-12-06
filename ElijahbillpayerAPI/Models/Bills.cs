namespace ElijahbillpayerAPI.Models
{
    public class Bills
    {
        //here is the model that controls all available Bills
        public int ID { get; set; }
        public string? Billid { get; set; }
        public string? BillName { get; set; }
        public string? Amount { get; set; }
        public string? Isactive { get; set; }
        
    }
}
