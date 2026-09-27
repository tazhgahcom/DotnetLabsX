DateTime localDateTime = DateTime.Now;
DateTime utcDateTime = DateTime.UtcNow;
DateTimeOffset dateTimeOffset = DateTimeOffset.Now;

DateOnly dateOnly = DateOnly.FromDateTime(localDateTime);
TimeOnly timeOnly = TimeOnly.FromDateTime(localDateTime);

Console.WriteLine(localDateTime);
Console.WriteLine(utcDateTime);
Console.WriteLine(dateTimeOffset);