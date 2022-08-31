using System;

namespace Ariel.CSharp.DesignPattern.Creational.AbstractFactory.Ships
{
    public class BigUfoShip : EnemyShip
    {
        public BigUfoShip()
        {
            Name = "BIIIIGG UFO Enemy Ship";
            Damage = 30.0;
            Speed = 10.0;
            Console.WriteLine($"{Name} has created");
        }
    }
}