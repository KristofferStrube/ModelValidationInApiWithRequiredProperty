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
        Assert.That(content, Does.Contain("One or more validation errors occurred."));
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
        Assert.That(content, Does.Contain("One or more validation errors occurred."));
    }
}
