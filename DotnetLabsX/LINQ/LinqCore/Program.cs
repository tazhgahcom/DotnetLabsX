using Dumpify;

namespace Tazhgah.LinqCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var listGames = new List<Game>()
            {
                new() {Id = 1, Title = "Avatar 1", Genre = "Adventurer", Price = 109, Rating = 9.5f, ReleaseYear = 2009},
                new() {Id = 2, Title = "Avatar 2", Genre = "Adventurer", Price = 89, Rating = 8.9f, ReleaseYear = 2010},
                new() {Id = 3, Title = "Avatar 3", Genre = "Adventurer", Price = 9.0f, Rating = 7.2f, ReleaseYear = 2013},
                new() {Id = 4, Title = "Toy Story 1", Genre = "RPG", Price = 99.9f, Rating = 7.9f, ReleaseYear = 2001},
                new() {Id = 4, Title = "Toy Story 2", Genre = "RPG", Price = 99.9f, Rating = 7.9f, ReleaseYear = 2001},
            };

            var listUsers = new List<User>()
            {
                new() {Id = 1, Name = "Siavash", Family = "Ebrahimi", Username = "tazhgahcom", Password = "pass123", IsDeleted = false},
                new() {Id = 2, Name = "Soroush", Family = "Ebrahimi", Username = "gabrieleb", Password = "pass123", IsDeleted = false},
                new() {Id = 3, Name = "Younes", Family = "Ebrahimi", Username = "younesebr", Password = "pass123", IsDeleted = false},
                new() {Id = 4, Name = "Yahya", Family = "Ebrahimi", Username = "yahyaebr", Password = "pass123", IsDeleted = false},
            };

            IEnumerable<int> collection = [1, 2, 3, 4, 5];
            IEnumerable<object> collection2 = [1, 2, "siavash", 3, "soroush", 4, 5, "younes", "yahya"];
            var numbers = new[] {10, 20, 30, 40, 50 };
            numbers.TakeLast(2).Dump();
            numbers.SkipLast(2).Dump();
            


            //collection.Where(item => item >= 3).Dump();
            //collection2.OfType<string>().Dump();
            //collection2.OfType<int>().Dump();

            //var firstUser = listUsers.OrderBy(user => user.Id).First();
            //var lastUser = listUsers.OrderByDescending(user => user.Id).First();


            //var averagePrice = listGames.Average(game => game.Price);
            //var highestRating = listGames.Max(game => game.Rating);
            //var bestGame = listGames.First(game => game.Rating == highestRating);

            //var groupGamesByGenre = listGames.GroupBy(game => game.Genre);
            //foreach (var group in groupGamesByGenre)
            //{
            //    Console.WriteLine($"Number of Games in {group.Key}: {group.Count()}");
            //}

            //var orderUsersByIdDesc = listUsers.OrderByDescending(user => user.Id).ToList();
            //foreach(var user in orderUsersByIdDesc)
            //{
            //    Console.WriteLine(user.Name);
            //}

            //var isSiavashExists = listUsers.Any(user => user.Username.ToLower() == "tazhgahcom");
            //Console.WriteLine($"Is Siavash Exists: {isSiavashExists}");

            //var isAnyUserDeleted = listUsers.Any(user => user.IsDeleted);
            //Console.WriteLine($"Are there any deleted users: {isAnyUserDeleted}");

            //var gameTitles = listGames.Select(g => g.Title).ToList();
            //var rpgGames = listGames.Where(game => game.Genre.ToLower() == "rpg").ToList();
            //var adventuresGames = listGames.Where(game => game.Genre.ToLower() == "adventurer").ToList();
            //var after2010Games = listGames.Where(game => game.ReleaseYear >= 2010).ToList();

            //Console.WriteLine($"Count of RPG: {rpgGames.Count}");
            //Console.WriteLine($"Count of Adventures: {adventuresGames.Count}");
            //Console.WriteLine($"Count of Recent Games: {after2010Games.Count}");

            //var deletedUsers = listUsers.Where(user => user.IsDeleted).ToList();
            //var nonDeletedUsers = listUsers.Where(user => !user.IsDeleted).ToList();

            //Console.WriteLine($"Count of Deleted Users: {deletedUsers.Count}");
            //Console.WriteLine($"Count of Non-Deleted Users: {nonDeletedUsers.Count}");
        }
    }
}