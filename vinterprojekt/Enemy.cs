class Enemy{
    public string name = "";
    private int hp;
    public int Hp{
        get {
            return hp;
        }
        set {
            hp = value;
            if (hp < 0){
                hp = 0;
                IsDead = true;
            }  
        }
    }

    public int minDamage;
    public int maxDamage;
    public double Armor;
    public bool IsDead { get; private set; }

    public void Attack(Player player){
        Console.WriteLine($"\n{name} attacks you!");
        int damage = Random.Shared.Next(minDamage, maxDamage); // Skadar spelaren ett random tal mellan minDamage och maxDamage
        player.Hp -= damage;

        Console.WriteLine($"{name} does {damage} damage!");
        Console.ReadLine();

    }

    public void Delete(List<Enemy> list){
        list.RemoveAt(0);
    }
}


class Monster : Enemy{
    public Monster(){
        name = "Monster";
        Hp = 100;
        minDamage = 10;
        maxDamage = 25;
        Armor = 0.1; //10% armor på fienden. Detta kommer dra av 10% från spelarens damage. 
    }
}

class Skivan : Enemy{
    public Skivan(){
        name = "Skivan Djivan";
        Hp = 250;
        minDamage = 40;
        maxDamage = 70;
        Armor = 0.8;
    }
}