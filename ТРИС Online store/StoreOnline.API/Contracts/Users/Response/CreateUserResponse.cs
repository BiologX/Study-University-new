namespace StoreOnline.API.Contracts.Users.Response
{
    public class CreateUserResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
