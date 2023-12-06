namespace ElijahbillpayerAPI.Models
{
    public class Priviledge
    {
        /****************THE PRIVILEDGE MODEL CONTROLS THE AUTHORITY GIVEN TO DIFFERNENT ROLE OF ADMIN****************************
         * ********************************
         * *************************************************/
        public int ID { get; set; }
        public string? Role { get; set; }
        public int Authority { get; set; }
        

    }
}
