// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Net.Http.Json;
using tracker_client;

HttpClient client = new();
client.BaseAddress = new Uri("https://localhost:7061");
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

HttpResponseMessage response = await client.GetAsync("api/issue");
response.EnsureSuccessStatusCode();

if (response.IsSuccessStatusCode)
{
    var issues = await response.Content.ReadFromJsonAsync<IEnumerable<IssueDto>>();
    foreach (var issue in issues)
    {
        Console.WriteLine($"Title: {issue.Title}");
        Console.WriteLine($"Description: {issue.Description}");
    }
}
else
{
    Console.WriteLine("No results");
}

Console.ReadLine();