namespace ElijahbillpayerAPI.Models
{
    public class Admin
    {
        //THE ADMIN MODEL CONTAILS THE CREDENTIALS OF DIFFERENT ADMIN AND THEIR ROLES
        //EACH ROLE AUTHORITY IS DEFINED BY THE PRIVILEGE MODEL
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? AdminToken { get; set; }
    }
}
