namespace StoreOnline.Core.DTO
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        private User(Guid id, string name, string login, string passwordHash)
        {
            Id = id;
            Name = name;
            Login = login;
            PasswordHash = passwordHash;
        }

        public static User Create(Guid id, string name, string login, string passwordHash)
        {
            return new User(id, name, login, passwordHash);
        }
    }
}
