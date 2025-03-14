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
    player.Attack(enemies[0], weapons);
    enemies[0].Attack(player);

    game.displayStats(player, enemies);
}

Console.ReadLine();




