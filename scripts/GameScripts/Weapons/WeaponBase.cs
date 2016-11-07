using System;
public class WeaponBase 
{
    public int power = 10;
    public float range = 1.0f;
    public int ammoCount = 100;

    public void fire()
    {
        for (int i = ammoCount; i > 0; i--)
        {
            ammoCount -- ;
            Console.Write("Fire " + ammoCount);
        }
    }

    public void SemiAutoFire()
    {
        int i = ammoCount;
        while (i > 0)
        {
            ammoCount -- ;
            Game.GameTimer();
            Console.Write("Fire " + ammoCount);
        }
    }
}