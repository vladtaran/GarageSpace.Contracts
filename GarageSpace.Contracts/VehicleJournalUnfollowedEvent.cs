namespace GarageSpace.Contracts
{
    public class VehicleJournalUnfollowedEvent
    {
        public long JournalId { get; init; }
        public long UnFollowerUserId { get; init; }
        public DateTime OccurredAt { get; init; }
    }
}
