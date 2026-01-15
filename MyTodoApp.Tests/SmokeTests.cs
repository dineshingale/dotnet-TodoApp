using System.Text.RegularExpressions;
using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

namespace MyTodoApp.Tests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class SmokeTests : PageTest
{
    [Test]
    public async Task Homepage_Should_Load_And_Have_Title()
    {
        // Check local development port from launchSettings.json
        await Page.GotoAsync("http://localhost:5256");

        // Verify title contains "MyTodoApp" or "Home" depending on layout
        // Let's assume standard template title or check for H1
        await Expect(Page).ToHaveTitleAsync(new Regex("Home Page")); 
    }
}
