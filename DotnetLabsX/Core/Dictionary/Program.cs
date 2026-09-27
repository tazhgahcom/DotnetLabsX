Dictionary<string, List<string>> wishlist = new();

wishlist.Add("siavash", new() { "C#", "WordPress", "Database" });
wishlist.Add("soroush", new() { "3D Max", "3D Modeling" });
wishlist.Add("younes", new() { "C#", "PHP", "Golang" });

Console.WriteLine(wishlist.Count);