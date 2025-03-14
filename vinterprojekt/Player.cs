class Player{
    public string name = "";
    private int hp = 200;
    public int Hp {
        get{
            return hp;
        }
        set{
            hp = value;
            if (hp < 0){
                hp = 0;
                IsDead = true;
            }  
        }
    }

    public bool IsDead { get; private set; }

    public int selectedWeapon = 0; //En int för att kunna referera till ett vapen i vapenlistan
    public void SelectWeapon(List<Weapon> weaponList) {
        bool end = false;
        int selected;

        while (end == false){
            Console.WriteLine($"Select a weapon: \n");
            foreach (Weapon weapon in weaponList){
                Console.WriteLine($"{weaponList.IndexOf(weapon) + 1}. {weapon.name} - Damage: {weapon.minDmg}-{weapon.maxDmg} - Armor Piercing: {weapon.armorPenetration}%");
            }

            string input = Console.ReadLine();
            if (int.TryParse(input.Trim(), out int result))
            {
                result -= 1;
                if (result > 0 && result < weaponList.Count()){
                    selectedWeapon = result;
                    end = true;
                    break;
                }
                else{
                    Console.WriteLine("Weapon does not exist, try again");
                    break;
                }
            }
            else{
                Console.WriteLine("Not a number, try again");
            }            
        }
    }

    public void Attack(Enemy target, List<Weapon> weaponList) {
        Console.WriteLine($"\nAttacking {target.name}!");
        Weapon playerWeapon = weaponList[selectedWeapon]; //Gör en variabel för spelarens vapen så man slipper referera till listan med vapen

        double damage = Random.Shared.Next(playerWeapon.minDmg, playerWeapon.maxDmg); //Skapar en random skada mellan spelarens minsta möjliga damage och högsta möjliga damage

        double armor = target.Armor * playerWeapon.armorPenetration; //Hur mycket armor fienden kommer ha kvar efter spelarens armor penetration

        target.Hp -= Convert.ToInt32(damage * armor);
        Console.WriteLine($"You did {damage * armor} damage!");
        Console.ReadLine();
    }
}

