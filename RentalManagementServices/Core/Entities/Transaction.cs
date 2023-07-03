namespace RentalManagementServices.Core
{
    public class Transaction
    {
        public long Id { get; set; }

        public string Channel { get; set; } 
        public string Reference { get; set; }    
        public string MpesaReference { get; set; }    
        public string BankReference { get; set; }    
        public string Narration { get; set; }    
        public string status { get; set; }    
        public long TenantId { get; set; }    
        public string PhoneNumber { get; set;}

        
        public long PricingId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

       
    }
}
