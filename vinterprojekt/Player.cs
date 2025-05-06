class Player{
    public string name = "";
    private int _hp = 200;
    public int Hp { // Denna är samma som i Enemy klassen
        get{
            return _hp;
        }
        set{
            _hp = value;
            if (_hp < 0){
                _hp = 0;
                isDead = true;
            }
            else{
                isDead = false;
            }
        }
    }
    public Weapon weapon; // Spelarens vapen

    public bool isDead { get; private set; }

    public void SelectWeapon(List<Weapon> weaponList) {
        bool end = false; // Variabel så att loopen under vet när den ska avslutas

        while (!end){ // Gör detta medans end är false
            Console.WriteLine($"Select a weapon: \n");

            foreach (Weapon weapon in weaponList){ // Skriver ut varje vapen och dess minimi och max skada så att spelaren kan välja en av de
                Console.WriteLine($"{weaponList.IndexOf(weapon) + 1}. {weapon.name} - Damage: {weapon.minDmg}-{weapon.maxDmg}");
            }

            string input = Console.ReadLine(); // Kollar vad spelaren skrev för att välja vapen. Måste vara en siffra
            if (int.TryParse(input.Trim(), out int result)) // Kollar om det faktiskt var en siffra
            {
                result -= 1; // Subtraherar med 1 eftersom att listor börjar räkna vid 0 istället för 1. Så om spelaren valde vapen 1 så blir det första vapnet i listan istället för andra
                if (result >= 0 && result < weaponList.Count()){ // Kollar om siffran som skrevs faktiskt finns som vapen för att undvika krasch
                    weapon = weaponList[result]; // Spelarens Weapon blir den man valde från listan
                    end = true; // End blir true så att loopen avslutas
                    Console.WriteLine($"You chose {weapon.name}"); // Skriver det man valde
                }
                else{
                    Console.WriteLine("Weapon does not exist, try again"); // Om siffran var för hög eller låg så skrivs detta
                }
            }
            else{
                Console.WriteLine("Not a number, try again"); // Om man inte skrev en siffra
            }            
        }
    }

    public void Attack(Enemy target) {
        Console.WriteLine($"\nAttacking {target.name}!");

        int damage = weapon.GetDamage(); // Hämtar en random skada

        target.Hp -= damage; // Skadar fienden

        Console.WriteLine($"You did {damage} damage!");
        Console.ReadLine();
    }
}

