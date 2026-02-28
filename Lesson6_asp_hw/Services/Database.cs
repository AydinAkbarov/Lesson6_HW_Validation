using Lesson6_asp_hw.Models;

namespace Lesson6_asp_hw.Services;

public static class Database
{
    public static List<User> Users = new()
    {
        new() { Name = "Robert",  Surname = "Johnson",   Age = 32, Email = "robert.johnson@gmail.com",   Password = "robert123",  Phone = "+1234567890" },
        new() { Name = "Mia",     Surname = "Davis",     Age = 27, Email = "mia.davis@gmail.com",        Password = "mia123",     Phone = "+1234567891" },
        new() { Name = "Oliver",  Surname = "Martinez",  Age = 36, Email = "oliver.martinez@gmail.com",   Password = "oliver123",  Phone = "+1234567892" },
        new() { Name = "Lily",    Surname = "Garcia",    Age = 30, Email = "lily.garcia@gmail.com",       Password = "lily123",    Phone = "+1234567893" },
        new() { Name = "Ethan",   Surname = "Miller",    Age = 42, Email = "ethan.miller@gmail.com",      Password = "ethan123",   Phone = "+1234567894" },
        new() { Name = "Ava",     Surname = "Rodriguez", Age = 24, Email = "ava.rodriguez@gmail.com",      Password = "ava123",     Phone = "+1234567895" },
        new() { Name = "Lucas",   Surname = "Martinez",  Age = 34, Email = "lucas.martinez@gmail.com",    Password = "lucas123",   Phone = "+1234567896" },
        new() { Name = "Chloe",   Surname = "Lopez",     Age = 29, Email = "chloe.lopez@gmail.com",        Password = "chloe123",   Phone = "+1234567897" },
        new() { Name = "Jackson", Surname = "Wilson",    Age = 48, Email = "jackson.wilson@gmail.com",    Password = "jackson123", Phone = "+1234567898" },
        new() { Name = "Zoe",     Surname = "Taylor",    Age = 31, Email = "zoe.taylor@gmail.com",        Password = "zoe123",     Phone = "+1234567899" }
    };

    public static List<User> GetAllUsers() => Users;
}
