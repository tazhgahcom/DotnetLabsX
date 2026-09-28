using System.Diagnostics.CodeAnalysis;

namespace Tazhgah.Core.PrimaryConstructors
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
            
        [SetsRequiredMembers]
        public User(string userName, string password)
        {
            Username = userName;
            Password = password;            
        }

        [SetsRequiredMembers]
        public User(string userName, string password, string role) : this(userName, password)
        {
            Role = role;
        }
    }
}
