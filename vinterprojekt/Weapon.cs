class Weapon {
    public string name = "";
    public int minDmg;
    public int maxDmg;
}


class Sword : Weapon {
    public Sword() { // Ger vapnet ett namn och en minimum damage och max damage som spelet kommer slumpa mellan.
        name = "Sword";
        minDmg = 40;
        maxDmg = 60;
    }
}

class Pistol : Weapon {
    public Pistol() {
        name = "Pistol";
        minDmg = 50;
        maxDmg = 70;
    }
}