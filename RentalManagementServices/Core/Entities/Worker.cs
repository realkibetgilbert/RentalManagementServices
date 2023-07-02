namespace RentalManagementServices.Core
{
    public class Worker
    {
        public long Id { get; set; }    
        public string Name { get; set; }    

        public string Description { get; set; }

        public long NationalId { get; set; }

        public DateTime DateofJoin { get; set; }

        public DateTime? DateofEnd { get; set; }

        public List<Room> Rooms { get; set; }
   
    }
}
