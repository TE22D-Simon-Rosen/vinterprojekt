
class Game{
    public void CreateEnemies(Queue<Enemy> queue){ //Gör instanser av enemy klassen och stoppar dem i en kö så att man kan slåss mot dem en efter en
        for (int i = 0; i < Random.Shared.Next(3, 5); i++){ //Gör mellan 3 och fem fiender
            int randomEnemy = Random.Shared.Next(1, 7); //Skapar ett värde mellan 1 och 7 för att slumpa mellan 4 olika fiender

            if (randomEnemy == 2){ //samma chans för dessa 3 fiender
                Festis festis = new();
                queue.Enqueue(festis); //Lägger fienden längst bak i kön
            }
            else if (randomEnemy == 2){
                Grigoryan skivan = new();
                queue.Enqueue(skivan);
            }
            else if (randomEnemy == 2){
                Monster monster = new();
                queue.Enqueue(monster);
            }
            else{ // Lägst chans för denna fiende
                SuperGrigoryan superGrigoryan = new();
                queue.Enqueue(superGrigoryan);
            }
        }
    }

    public void DisplayStats(Player player, Queue<Enemy> queue){ //Skriver ut spelarens och fiendens HP
        Console.WriteLine($"\nplayer: {player.Hp}  |  enemy: {queue.Peek().Hp} \nEnemies remaining: {queue.Count()}");
        Console.ReadLine();
    }
}