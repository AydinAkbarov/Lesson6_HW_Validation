using Lesson6_asp_hw.Models;

namespace Lesson6_asp_hw.Services;
public static class Database
{
    public static List<User> users = new List<User>()
{
    new User() { Name="Robert",  Surname="Johnson", Age=32, Email="robert.johnson@gmail.com", Password="robert123", Phone="+1234567890" },
    new User() { Name="Mia",     Surname="Davis",   Age=27, Email="mia.davis@gmail.com",   Password="mia123",     Phone="+1234567891" },
    new User() { Name="Oliver",  Surname="Martinez",Age=36, Email="oliver.martinez@gmail.com", Password="oliver123", Phone="+1234567892" },
    new User() { Name="Lily",    Surname="Garcia",  Age=30, Email="lily.garcia@gmail.com",  Password="lily123",    Phone="+1234567893" },
    new User() { Name="Ethan",   Surname="Miller",  Age=42, Email="ethan.miller@gmail.com", Password="ethan123",   Phone="+1234567894" },
    new User() { Name="Ava",     Surname="Rodriguez", Age=24, Email="ava.rodriguez@gmail.com", Password="ava123",    Phone="+1234567895" },
    new User() { Name="Lucas",   Surname="Martinez", Age=34, Email="lucas.martinez@gmail.com", Password="lucas123", Phone="+1234567896" },
    new User() { Name="Chloe",   Surname="Lopez",   Age=29, Email="chloe.lopez@gmail.com", Password="chloe123",   Phone="+1234567897" },
    new User() { Name="Jackson", Surname="Wilson",  Age=48, Email="jackson.wilson@gmail.com", Password="jackson123", Phone="+1234567898" },
    new User() { Name="Zoe",     Surname="Taylor",  Age=31, Email="zoe.taylor@gmail.com",   Password="zoe123",     Phone="+1234567899" }
};

    public static List<User> GetAllUsers()
    {
        return users;
    }
}
