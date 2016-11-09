using System;
public class Game
{
    public static bool canPlay = true;
    public Game()
    {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
        Cave.StartMessage = ("You have entered a cave");
        Underwater.objects = new string[] {"Seaweed", "Coral", "Fish", "Shark"};
        }
    public void Start()
    {
        Console.WriteLine("Please type in your name.");
        name = Console.ReadLine();
        Console.WriteLine("Your Player name is: " + name);
        Cave.Enter();
        while (Game.canPlay)
        {
            GameTimer();
            Play();

        }
        Console.WriteLine("You Died.");
        Console.WriteLine("Game Over.");
    }
    private void Play()
    {
        Console.WriteLine("Play Commands:  play, end, help");
        switch (GameState.GameStates.End)
        {
            case GameState.GameStates.End:
                Console.WriteLine("Game Over");
                Environment.Exit(0);
                break;
            case GameState.GameStates.Help:
                Console.WriteLine("What do you need help for?  If you can't play this game you have issues");
                Play();
            break;
            case GameState.GameStates.Play:

            break;
            default:
                Console.WriteLine(" is not a valid option");
                Play();
            break;
        }

        Random randomNum = new Random();
        Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
    }
    public static void GameTimer ()
    {
        System.Threading.Thread.Sleep(2000);
    }
    //Game Levels
    private LevelBase Cave = new CaveLevel();
    public static LevelBase Underwater = new LevelBase();
    //Game PowerUps
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();

    //Game Weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();
    private WeaponBase Knife = new WeaponBase();
    public string name;
    private int score;
}