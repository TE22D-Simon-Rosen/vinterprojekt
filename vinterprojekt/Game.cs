
class Game{
    public void createEnemies(List<Enemy> list){
        for (int i = 0; i < Random.Shared.Next(3, 5); i++){
            int randomEnemy = Random.Shared.Next(1, 4);

            if (randomEnemy == 1){
                Skivan skivan = new();
                list.Add(skivan);
            }
            else{
                Monster monster = new();
                list.Add(monster);
            }
        }
    }

    public void displayStats(Player player, List<Enemy> list){
        Console.WriteLine($"\nplayer: {player.Hp}  |  enemy: {list[0].Hp}");
        Console.ReadLine();
    }
}