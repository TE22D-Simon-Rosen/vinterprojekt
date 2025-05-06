Player player = new();
Game game = new();

Console.WriteLine("Input a username: ");
player.name = Console.ReadLine().Trim(); // Tar bort alla mellanslag som är innan och efter det man skrev

Sword sword = new(); // Skapar två olika vapen som sedan läggs i en lista
BigSword bigSword = new();
Pistol pistol = new();

List<Weapon> weapons = [sword, bigSword, pistol]; 
Queue<Enemy> enemies = new(); // Kö för fiender istället fösr lista eftersom att programmet inte behöver komma åt någon annan fiende än den
// som är först i kön. Det är också mindre krävande på systemet

Console.WriteLine("Select a weapon by typing the corresponding number. Anything but a valid number will not work");
player.SelectWeapon(weapons); // Låter spelaren välja sitt vapen

game.CreateEnemies(enemies); // Skapar fienderna som spelaren ska slåss mot



while (game.play){ // Medans play variabeln är true så kommer spelet att vara igång
    game.GameLoop(player, enemies); // Kör spellogiken
    
    if (game.CheckRetry() == "y"){ // kollar om man vill fortsätta
        game.Reset(player, enemies, weapons); // Startar om om man vill köra igen
        game.GameLoop(player, enemies);
    }
    else{
        game.play = false; // Om man inte vill fortsätta så avslutas spelet
    }
}

Console.ReadLine();




