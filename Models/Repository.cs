namespace MeetingApp.Models;

public static class Repository
{
    private static List<UserInfo> _users = new();

    static Repository()
    {
        _users.Add(new UserInfo(){Id=1, Name = "Merve", Email = "merve@gmail.com", Phone = "35677544563", WillAttend = true});
        _users.Add(new UserInfo(){Id=2, Name = "Alp", Email = "alp@gmail.com", Phone = "3567745543", WillAttend = false});
        _users.Add(new UserInfo(){Id=3, Name = "Giray", Email = "giray@gmail.com", Phone = "45535677543", WillAttend = true});
    }

    public static List<UserInfo> Users
    {
        get
        {
            return _users;
        }
    }

    public static void CreateUser(UserInfo user)
    {
        user.Id = Users.Count + 1;
        _users.Add(user);
    }

    public static UserInfo? GetById(int id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }
}