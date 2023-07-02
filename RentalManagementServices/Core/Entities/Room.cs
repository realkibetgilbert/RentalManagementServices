namespace RentalManagementServices.Core
{
    public class Room
    {
        public long Id { get; set; }

        public string Name { get; set; }    

        public string Dimension { get; set; }   

        public long TenantId { get; set; }

        public Tenant Tenant { get; set; }  

        public long PricingId { get; set; }

        public Pricing Pricing { get; set; }

        public List<Worker> Workers { get; set; }
    }
}
