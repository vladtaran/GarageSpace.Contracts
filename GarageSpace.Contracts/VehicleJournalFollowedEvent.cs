namespace GarageSpace.Contracts
{
    public class VehicleJournalFollowedEvent
    {
        public long JournalId { get; init; }
        public long FollowerUserId { get; init; }
        public DateTime OccurredAt { get; init; }
    }
}
