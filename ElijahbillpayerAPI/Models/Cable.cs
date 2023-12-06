namespace ElijahbillpayerAPI.Models
{
    public class Cable
    {
        //here is the model that controls all available Cable Operators and their plan
        public int ID { get; set; }
        public string? CableOperator { get; set; }
        public string? TotalCredit { get; set; }
        public string? CablePlan { get; set; }
        public string? CablePrice { get; set; }
        public string? CableID { get; set; }
        public string? CableMonth { get; set; }
      
    }
}
