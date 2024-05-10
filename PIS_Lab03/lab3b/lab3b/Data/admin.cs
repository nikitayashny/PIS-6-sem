using lab3b.Models;

namespace lab3b.Data
{
    public static class Admin
    {
        public static List<User> users = new()
    {
        new User() { Name = "nikita.yashny@gmail.com", Password = "Nikita_2004", Roles = new[] { Roles.Administrator } },
    };
    }
}
