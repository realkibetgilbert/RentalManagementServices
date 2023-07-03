﻿namespace RentalManagementServices.Core.Entities
{
    public class WorkerRoom
    {
        public long WorkerId { get; set; }
        public Worker Worker {get; set; }

        public long RoomId { get; set; }
        public Room Room { get; set; }
    }
}
