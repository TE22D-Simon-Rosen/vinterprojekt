class Weapon {
    public string name = "";
    public int minDmg;
    public int maxDmg;
}


class Sword : Weapon {
    public Sword() {
        name = "Sword";
        minDmg = 15;
        maxDmg = 30;
    }
}