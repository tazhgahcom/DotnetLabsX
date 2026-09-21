using System.Diagnostics.CodeAnalysis;
using Tazhgah.Core.Interfaces.Interfaces;

namespace Tazhgah.Core.Interfaces.Models
{
    public class UserModel
    {
        public required int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }

        [SetsRequiredMembers]
        public UserModel()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}
