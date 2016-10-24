public class Game
{
    public Game()
    {
        Gun.fire();
    }
    private WeaponBase Gun = new WeaponBase();
    public string name;
    private int score;
}