namespace ElijahbillpayerAPI.Models
{
    public class SmsVerify
    {
        //this is for sms verification
        public int ID { get; set; }
        public string? UserID { get; set; }
        public int OTP { get; set; }
        public string? Expiry { get; set; }
        public string? Validate { get; set; }
    }
}
