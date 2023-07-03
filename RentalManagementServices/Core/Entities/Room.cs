using RentalManagementServices.Core.Entities;

namespace RentalManagementServices.Core
{
    public class Room
    {
        public long Id { get; set; }

        public string Name { get; set; }    

        public string Dimension { get; set; }   

        public bool IsVacant { get; set; }  

        public Tenant Tenant { get; set; }  
        public long TenantId { get; set; }

        public ICollection<WorkerRoom> WorkerRooms { get; set; }
    }
}
