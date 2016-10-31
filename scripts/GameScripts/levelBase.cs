using System;
public class LevelBase
{
    public string StartMessage;
    public bool entranceOpen = true;
    public string[] environment = {"cold", "wet", "dark"};
    public string[] objects = {"Rocks", "Ravine", "River", "Lava"};
    public void Enter()
    {
        Console.WriteLine(StartMessage);
    }
    public void Encounter (int i)
    {
        switch (i)
        {
            case 0:
                Console.WriteLine("You've walked into " + objects[i]);
            break;

            case 1:
                Console.WriteLine("You've walked into " + objects[i]);
            break;

            case 2:
                Console.WriteLine("You've walked into " + objects[i]);
                Game.GameTimer();
                Random randomNum = new Random();
                Game.Underwater.Encounter(randomNum.Next(0, Game.Underwater.objects.Length));
            break;

            case 3:
                Console.WriteLine("You've walked into " + objects[i]);
                Game.canPlay = false;
            break;

            default: Console.WriteLine("Your path is clear");

            break;
        }
    }
}