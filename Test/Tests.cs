using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace Test;

public class Tests
{
    [Test]
    public async Task ControllerAPI_EmptyBody_ShouldGiveProblemDetails()
    {
        // Arrange
        var factory = new WebApplicationFactory<ControllerAPI.Program>();
        var client = factory.CreateClient();

        // Act
        var response = await client.PostAsJsonAsync("/order", new { });

        var content = await response.Content.ReadAsStringAsync();

        // Assert
        // A Problem Details will include this link
        Assert.That(content, Does.Contain("https://tools.ietf.org/html/rfc9110#section-15.5.1"));
    }

    [Test]
    public async Task MinimalAPI_EmptyBody_ShouldGiveProblemDetails()
    {
        // Arrange
        var factory = new WebApplicationFactory<MinimalAPI.Program>();
        var client = factory.CreateClient();

        // Act
        var response = await client.PostAsJsonAsync("/order", new { });

        var content = await response.Content.ReadAsStringAsync();

        // Assert
        // A Problem Details will include this link
        Assert.That(content, Does.Contain("https://tools.ietf.org/html/rfc9110#section-15.5.1"));
    }
}
