Dictionary<string, List<string>> wishlist = new();

wishlist.Add("siavash", new List<string>() { "C#", "WordPress", "Database" });
wishlist.Add("soroush", new List<string>() { "3D Max", "3D Modeling" });
wishlist.Add("younes", new List<string>() { "C#", "PHP", "Golang" });

Console.WriteLine(wishlist.Count);