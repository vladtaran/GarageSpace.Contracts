using GarageSpace.Contracts.Interfaces;

namespace GarageSpace.Contracts
{
    public class VehicleJournalUnfollowedEvent : IEventMessage
    {
        public long JournalId { get; init; }
        public long UnFollowerUserId { get; init; }
        public DateTime OccurredAt { get; init; }
    }
}
