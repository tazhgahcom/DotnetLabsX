UserModel um = new()
{
    Id = 1,
    Username = "tazhgahcom",
    Password = "pass123"
};

PostModel pm = new()
{
    Id = 1,
    Title = "C# Programming Language",
    Content = "This is a course about c# programming langauge"
};

MediaModel mm = new()
{
    Id = 1,
    Name = "file1.jpg",
};

PersonModel pm2 = new()
{
    Id = 1,
    FirstName = "Siavash",
    LastName = "Ebrahimi",
    Address = new AddressModel()
    {
        City = "Kouhdasht",
        State = "Lorestan"
    }
};

pm.Dump();
um.Dump();
mm.Dump();
pm2.Dump();