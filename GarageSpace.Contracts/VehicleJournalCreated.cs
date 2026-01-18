namespace GarageSpace.Contracts
{
    public class VehicleJournalCreated
    {
        public long JournalId { get; set; }
        public long OwnerId {  get; set; }
        public required string Name { get; set; }
        public required string Model { get; set; }
    }
}
