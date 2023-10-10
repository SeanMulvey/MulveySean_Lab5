using System.Net.Http.Headers;

int userNum;


Console.WriteLine("Enter a whole number: ");
userNum = Int32.Parse(Console.ReadLine());
var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri($"https://numbersapi.p.rapidapi.com/random/trivia?min={userNum}&max={userNum}&fragment=true&json=true"),
    Headers =
    {
        { "X-RapidAPI-Key", "20daf3bc80msh76a4e116dfd7d8dp1bbcf0jsn99e52a1764d3" },
        { "X-RapidAPI-Host", "numbersapi.p.rapidapi.com" },
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}