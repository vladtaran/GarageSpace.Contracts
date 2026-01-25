using GarageSpace.Contracts.Interfaces;

namespace GarageSpace.Contracts
{
    public class UserBlogFollowedEvent : IEventMessage
    {
        public long UserId { get; init; }
        public long FollowerUserId { get; init; }
        public DateTime OccurredAt { get; init; }
    }
}
