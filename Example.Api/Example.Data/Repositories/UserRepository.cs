using Example.Data.Models;

namespace Example.Data.Repositories;

public class UserRepository : IUserRepository
{
    public User? GetUserById(int userId)
    {
        throw new NotImplementedException();
    }

    public User? GetUserByUsername(string username)
    {
        if (string.IsNullOrWhiteSpace(username)) return null;
        
        return new User { Id = 1, Username = "hello_world", Email = "hello@world" };
    }

    public User? GetUserByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public void AddUser(User user)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(int userId)
    {
        throw new NotImplementedException();
    }
}