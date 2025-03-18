Player player = new();
Game game = new();

Console.WriteLine("Input a name: ");
player.name = Console.ReadLine().Trim();

Sword Sword = new(); 
Pistol Pistol = new();

List<Weapon> weapons = [Sword, Pistol];
List<Enemy> enemies = new();

Console.WriteLine("Select a weapon by typing the corresponding number: ");
player.SelectWeapon(weapons);

game.createEnemies(enemies);


while (!player.IsDead) {
    game.displayStats(player, enemies);
    
    player.Attack(enemies[0], weapons);
    if (!enemies[0].IsDead){
        enemies[0].Attack(player);
    }
    else{
        enemies[0].Delete(enemies);
    }
    
}

if (player.IsDead){
    Console.WriteLine("\nYou Lost!");
}
else{
    Console.WriteLine("\nYou Win!");
}

Console.ReadLine();




