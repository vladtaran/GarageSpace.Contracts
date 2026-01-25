using GarageSpace.Contracts.Interfaces;

namespace GarageSpace.Contracts
{
    public class UserArchived : IEventMessage
    {
        public long UserId { get; set; }
    }
}
