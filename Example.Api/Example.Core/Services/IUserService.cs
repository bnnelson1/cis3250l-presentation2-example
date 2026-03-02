using Example.Data.Models;

namespace Example.Core.Services;

public interface IUserService
{
    User? GetUserByUsername(string username);
}
