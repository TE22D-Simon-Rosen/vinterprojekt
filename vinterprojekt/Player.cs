class Player{
    public string name = "";

    public int Hp {
        set {
            Hp = value;
        }
        get {
            return Hp;
        }
    }

    public bool IsDead { get; private set; }

    public List<Weapon> Inventory { get; private set; }
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
                if (result > 0 && result < weaponList.Count()){
                    Inventory.Add(weaponList.);
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

    public void Attack(Enemy target) {

    }
}

