using System.Net.Http.Json;
HttpClient client = new();
client.BaseAddress = new("https://random-word-api.herokuapp.com/"); //Bas API

List<string> words = new();

HttpResponseMessage response = client.GetAsync("word?length=5").Result; //Hämtar ett random ord på 5 bokstäver

words = response.Content.ReadFromJsonAsync<List<string>>().Result;

File.WriteAllText("word.json", response.Content.ReadAsStringAsync().Result);

Console.WriteLine(words[0]);


Console.ReadLine();