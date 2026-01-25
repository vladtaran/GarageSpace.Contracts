using GarageSpace.Contracts.Interfaces;

namespace GarageSpace.Contracts
{
    public class UserRegistered : IEventMessage
    {
        public long UserId { get; set; }
        public required string Name { get; set; }
        public required string Nickname { get; set; }
        public required string Email { get; set; }
    }
}
