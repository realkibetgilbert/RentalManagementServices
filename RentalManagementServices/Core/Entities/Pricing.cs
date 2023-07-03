namespace RentalManagementServices.Core
{
    public class Pricing
    {
        public long Id { get; set; }    

        public string Description { get; set; }

        public double Amount { get; set; }  

        public double DepositAmount { get; set; } 

        public bool IsActive { get; set; }    
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set;}
        
    }
}
