class Weapon {
    public string name = ""; // Namn på vapnet
    public int minDmg; // Minimum skada som det kan göra
    public int maxDmg; // Max skada


    public int GetDamage(){ // Returnerar en slumpmässig skada
        int damage = Random.Shared.Next(minDmg, maxDmg);
        return damage;
    }
}


class Sword : Weapon {
    public Sword() { // Ger vapnet ett namn och en minimum damage och max damage som spelet kommer slumpa mellan.
        name = "Sword";
        minDmg = 40;
        maxDmg = 60;
    }
}


class BigSword : Sword { // Sword fast bättre
    public BigSword() {
        name = "Big Sword (very good :))";
        minDmg = 100;
        maxDmg = 150;
    }
}


class Pistol : Weapon {
    public Pistol() {
        name = "Pistol";
        minDmg = 50;
        maxDmg = 70;
    }
}