namespace GarageSpace.Contracts
{
    public class UserBlogUnfollowedEvent
    {
        public long UserId { get; init; }
        public long FollowerUserId { get; init; }
        public DateTime OccurredAt { get; init; }
    }
}
