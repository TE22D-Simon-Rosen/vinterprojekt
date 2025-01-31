using System.Formats.Asn1;
using System.Net.Http.Json;
Settings settings = new();

HttpClient client = new();
client.BaseAddress = new("https://random-word-api.herokuapp.com/"); //Bas API

List<string> words = new();


HttpResponseMessage response = client.GetAsync($"word?length={settings.wordLength.ToString()}").Result; //Hämtar ett random ord på 5 bokstäver

words = response.Content.ReadFromJsonAsync<List<string>>().Result;

File.WriteAllText("word.json", response.Content.ReadAsStringAsync().Result);

Console.WriteLine(words[0]);

//Start
bool temp = true;
Console.WriteLine("--Wordle-- \n\n1. Start \n2.Settings \n\nType the corresponding number to select");
string input = Console.ReadLine();

while (temp){}

//Checks if the imput corresponds to any number above
if (input.Trim() != "1" || input.Trim() != "2"){
    Console.WriteLine($"\n{input.Trim()} is not an option, try again");
}
else if (input.Trim() == "1"){
    temp = false;
}
else{
    settings.Show();
}


Console.ReadLine();