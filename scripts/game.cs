using System;
public class Game
{
    public Game()
    {
        Gun.fire();
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
        Console.WriteLine(Health.power);
        Console.WriteLine(Ammo.power);
    }
    public void Start()
    {
        Health.RunPowerUp();
        /*
        AFter prompt the game for a name we:
        Enter a Cave
        Find Health
        Meet dragon (need an enemy class)
        pick Weapon.
        Battle dragon
        if we win: get health and ammo
        if dragon wins: lose health
        */
    }
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