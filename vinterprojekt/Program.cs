using System.Runtime.Serialization;

Player player = new();
Game game = new();

Console.WriteLine("Input a username: ");
player.name = Console.ReadLine().Trim();

Sword sword = new(); // Skapar två olika vapen som sedan läggs i en lista
BigSword bigSword = new();
Pistol pistol = new();

List<Weapon> weapons = [sword, bigSword, pistol]; 
Queue<Enemy> enemies = new(); // Kö för fiender istället fösr lista eftersom att programmet inte behöver komma åt någon annan fiende än den
// som är först i kön. Det är också mindre krävande på systemet

Console.WriteLine("Select a weapon by typing the corresponding number. Anything but a valid number will not work");
player.SelectWeapon(weapons); // Låter spelaren välja sitt vapen

game.CreateEnemies(enemies); // Skapar fienderna som spelaren ska slåss mot


while (!player.isDead) {
    game.DisplayStats(player, enemies); // Visar spelarens och fiendens hp innan man attackerar
    
    player.Attack(enemies.Peek()); // Attackerar fienden man slåss mot just nu
    if (!enemies.Peek().isDead){ // Kollar om fienden dog så att den inte kan attackera även om den är död
        enemies.Peek().Attack(player); // Fienden som är längst fram i kön attackerar
    }
    else{
        if (enemies.Count() > 0){ // Kollar om kön inte är tom för att undvika att programmet kraschar
            enemies.Dequeue(); // Tar bort fienden som är längst fram i kön, alltså den man precis dödade
            Console.ReadLine();
        }
    }

    if (enemies.Count() == 0){ // Avslutar loopen om alla fiender är döda
        break;
    }
}


if (player.isDead){ // Om spelaren dog så skrivs det att man förlora, annars så vinner man
    Console.WriteLine("\nYou Lost!");
}
else{
    Console.WriteLine("\nYou Win!");
}

Console.ReadLine();




