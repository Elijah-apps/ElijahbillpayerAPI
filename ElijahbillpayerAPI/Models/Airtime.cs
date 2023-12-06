namespace ElijahbillpayerAPI.Models
{
    public class Airtime
    {
        //Here is the model that controls all available airtime
        public int ID { get; set; }
        public string? Network { get; set; }
        public decimal? TotalCredit { get; set; }
        public decimal? SoldCredit { get; set; }
        public string? Status { get; set; }
        public string? AirtimeId { get; set; }
        public string? PhoneCode { get; set; }
        public string?  Requests { get; set; }
    }
}
