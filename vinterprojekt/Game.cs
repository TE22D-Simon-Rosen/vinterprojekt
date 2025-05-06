
class Game{
    public bool play = true;
    public void CreateEnemies(Queue<Enemy> queue){ //Gör instanser av enemy klassen och stoppar dem i en kö så att man kan slåss mot dem en efter en
        for (int i = 0; i < Random.Shared.Next(3, 5); i++){ //Gör mellan 3 och fem fiender
            int randomEnemy = Random.Shared.Next(1, 7); //Skapar ett värde mellan 1 och 7 för att slumpa mellan 4 olika fiender

            if (randomEnemy == 1 || randomEnemy == 2){ //samma chans för dessa 3 fiender
                Festis festis = new();
                queue.Enqueue(festis); //Lägger fienden längst bak i kön
            }
            else if (randomEnemy == 3 || randomEnemy == 4){
                Grigoryan skivan = new();
                queue.Enqueue(skivan);
            }
            else if (randomEnemy == 5 || randomEnemy == 6){
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


    public void Reset(Player player, Queue<Enemy> queue, List<Weapon> list){
        queue.Clear(); // Tar bort alla fiender som är kvar i kön
        CreateEnemies(queue); // Skapar nya fiender
        player.Hp = 100; // återställer spelarens hp till 100
        player.SelectWeapon(list); // Låter spelaren välja ett nytt vapen
    }

    public string CheckRetry(){ // Returnerar en string för att kolla om spelaren vill spela igen. Om variabeln som returneras är "y" så körs spelet igen
        Console.WriteLine("Type y to play again, anything else will end the game");
        string input = Console.ReadLine();
        return input;
    }


    public void GameLoop(Player player, Queue<Enemy> enemies)
    {
        while (!player.isDead)
        {
            DisplayStats(player, enemies); // Visar spelarens och fiendens hp innan man attackerar

            player.Attack(enemies.Peek()); // Attackerar fienden man slåss mot just nu
            if (!enemies.Peek().isDead)
                { // Kollar om fienden dog så att den inte kan attackera även om den är död
                    enemies.Peek().Attack(player); // Fienden som är längst fram i kön attackerar
                }
            else
                {
                    if (enemies.Count() > 0)
                    { // Kollar om kön inte är tom för att undvika att programmet kraschar
                        enemies.Dequeue(); // Tar bort fienden som är längst fram i kön, alltså den man precis dödade
                        Console.ReadLine();
                    }
                }

            if (enemies.Count() == 0)
                { // Avslutar loopen om alla fiender är döda
                    break;
                }
        }

        if (player.isDead)
            { // Om spelaren dog så skrivs det att man förlora, annars så vinner man
                Console.WriteLine("\nYou Lost!");
            }
        else
            {
                Console.WriteLine("\nYou Win!");
            }
    }
}