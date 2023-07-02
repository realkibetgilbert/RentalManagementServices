namespace RentalManagementServices.Core
{
    public class Tenant
    {
        public long Id { get; set; }    

        public string Name { get; set; }  

        public string PhoneNumber { get; set; }

        public DateTime DateofJoin { get; set; }

        public DateTime? DateofLeaving { get; set; }

        public long RoomId { get; set; }

        public Room Room { get; set; }
    }
}
