
class Game{
    public void createEnemies(List<Enemy> list){ //Gör instanser av enemy klassen och stoppar dem i en lista
        for (int i = 0; i < Random.Shared.Next(3, 5); i++){ //Gör mellan 3 och fem fiender
            int randomEnemy = Random.Shared.Next(1, 4); //Skapar ett värde mellan 1 och 4 för att slumpa mellan 2 olika fiender

            if (randomEnemy == 1){ //25% chans för denna fiende
                Skivan skivan = new();
                list.Add(skivan);
            }
            else{ //75% för denna
                Monster monster = new();
                list.Add(monster);
            }
        }
    }

    public void displayStats(Player player, List<Enemy> list){ //Skriver ut spelarens och fiendens HP
        Console.WriteLine($"\nplayer: {player.Hp}  |  enemy: {list[0].Hp}");
        Console.ReadLine();
    }
}