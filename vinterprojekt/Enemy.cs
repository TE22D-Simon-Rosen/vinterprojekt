class Enemy{
    public string name = ""; // Monstrets namn
    private int _hp; // Monstrets start hälsa
    public int Hp{  // Samma som hp men det är denna man ändrar på under spelets gång för att slippa kolla om hp är under 0 varje gång man ändrar
        get {
            return _hp; // Om programmet ska referera till Hp variabeln så hämtar den hp variabeln med litet h
        }
        set {
            _hp = value; // Om programmet ska ändra variabeln så ändrar den hp med litet h till vad som anges
            if (_hp < 0){ // Men om hp blir mindre än 0 så sätter den hp till 0 och växlar IsDead till true samt skriver att fienden är död
                _hp = 0;  // ^^^ Detta gör så att man slipper skriva kod för att kolla om hp är mindre än 0 varje gång man ska ändra det
                isDead = true;
                Console.WriteLine($"\n{name} died!");
            }
        }
    }

    public int minDamage;
    public int maxDamage;
    public bool isDead { get; private set; } // Programmet kan bara hämta denna variabel. Den kan bara ändras i själva klassen ^^^

    public void Attack(Player player){
        if (!isDead){
            Console.WriteLine($"\n{name} attacks you!"); // Skriver ut att fienden attackerar
            int damage = Random.Shared.Next(minDamage, maxDamage); // Skadar spelaren ett random tal mellan minDamage och maxDamage
            player.Hp -= damage; // Tar bort så mycket skada som fienden gör från spelarens hp

            Console.WriteLine($"{name} does {damage} damage!"); // Skriver ut hur mycket skada som görs på spelaren
            Console.ReadLine(); // En readline så att programmet inte fortsätter direkt
        }
    }
}


class Monster : Enemy{
    public Monster(){
        name = "Monster"; // Sätter fiendens namn till Monster
        Hp = 100; // Sätter Hp till 100
        minDamage = 10; // minsta skada som fienden kan göra
        maxDamage = 25; // Högsta skada den kan göra
    }
}

class Festis : Enemy{
    public Festis(){
        name = "Festis Guanabanana";
        Hp = 100;
        minDamage = 10;
        maxDamage = 25;
    }
}

class Grigoryan : Enemy{
    public Grigoryan(){
        name = "Grigoryan";
        Hp = 250;
        minDamage = 40;
        maxDamage = 70;
    }
}

class SuperGrigoryan : Grigoryan{ // En starkare version av Grigorian fienden
    public SuperGrigoryan(){
        name = "Super Grigoryan";
        Hp = 500;
        minDamage = 60;
        maxDamage = 80;
    }
}