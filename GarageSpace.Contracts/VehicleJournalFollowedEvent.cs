using GarageSpace.Contracts.Interfaces;

namespace GarageSpace.Contracts
{
    public class VehicleJournalFollowedEvent : IEventMessage
    {
        public long JournalId { get; init; }
        public long FollowerUserId { get; init; }
        public DateTime OccurredAt { get; init; }
    }
}
