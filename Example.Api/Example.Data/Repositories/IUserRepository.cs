using Example.Data.Models;

namespace Example.Data.Repositories;

public interface IUserRepository
{
    public User? GetUserById(int userId);
    
    public User? GetUserByUsername(string username);
    
    public User? GetUserByEmail(string email);
    
    public void AddUser(User user);
    
    public void UpdateUser(User user);
    
    public void DeleteUser(int userId);
}
