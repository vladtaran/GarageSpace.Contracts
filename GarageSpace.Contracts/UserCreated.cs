namespace GarageSpace.Contracts
{
    public class UserCreated
    {
        public long UserId { get; set; }
        public required string Name { get; set; }
    }
}
