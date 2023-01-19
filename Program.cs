// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Linq;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Hello, World!");
var kanyeURL = "https://api.kanye.rest";
var client1 = new HttpClient();
var kanyeResponse = client1.GetStringAsync(kanyeURL).Result;
var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
Console.WriteLine(kanyeQuote); 

var ronURL = "https://api.kanye.rest";
var client2 = new HttpClient();
var ronResponse = client2.GetStringAsync(ronURL).Result;
var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
Console.WriteLine(ronQuote);
