using GarageSpace.Contracts.Interfaces;

namespace GarageSpace.Contracts
{
    public class VehicleJournalCreated : IEventMessage
    {
        public long JournalId { get; set; }
        public long OwnerId {  get; set; }
        public required string Name { get; set; }
        public required string Model { get; set; }
    }
}
