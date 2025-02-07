class Enemy{
    public string Name { get; private set; }
    private int hp;
    public int Hp{
        get {
            return hp;
        }
        set {
            hp = value;
            if (hp < 0) hp = 0;
        }
    }

    public int Damage { get; private set; }
}


class 