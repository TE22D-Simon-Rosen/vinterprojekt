Player player = new();

Console.WriteLine("Input a name: ");
player.name = Console.ReadLine().Trim();

Sword Sword = new(); 
Pistol Pistol = new();

List<Weapon> weapons = [Sword, Pistol];

foreach(Weapon weapon in weapons){
    Console.WriteLine(weapon);
}

Console.WriteLine("Select your weapons. You will be able to choose 2 weapons. Select by typing the corresponding number: ");
player.SelectWeapon(weapons);
player.SelectWeapon(weapons);

foreach(Weapon weapon in weapons){
    Console.WriteLine(weapon);
}

Console.ReadLine();




