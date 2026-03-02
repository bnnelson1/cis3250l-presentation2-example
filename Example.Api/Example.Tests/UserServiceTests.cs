using Example.Core.Services;
using Example.Data.Models;
using Example.Data.Repositories;
using NSubstitute;
using Shouldly;

namespace Example.Tests;

public class UserServiceTests
{
    [Fact]
    public void Requesting_an_existing_user_by_username_returns_the_user()
    {
        const string username = "jane_doe";
        var user = new User { Id = 2, Username = username, Email = "janedoe@proton.me" };
        var repository = Substitute.For<IUserRepository>();
        repository.GetUserByUsername(username).Returns(user);

        var service = new UserService(repository);
        var returnedUser = service.GetUserByUsername(username);
        
        returnedUser.ShouldBeEquivalentTo(user);
        repository.Received().GetUserByUsername(username);
    }
}