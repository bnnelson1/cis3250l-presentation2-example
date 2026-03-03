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
        // Arrange
        const string username = "jane_doe";
        var expectedUser = new User { Id = 2, Username = username, Email = "janedoe@proton.me" };
        
        var database = Substitute.For<IUserRepository>();
        database.GetUserByUsername(username).Returns(expectedUser);
        
        var service = new UserService(database);
        
        // Act
        var actualUser = service.GetUserByUsername(username);
        
        // Assert
        actualUser.ShouldBeEquivalentTo(expectedUser);
        database.Received().GetUserByUsername(username);  // Included here for completion
    }
}
