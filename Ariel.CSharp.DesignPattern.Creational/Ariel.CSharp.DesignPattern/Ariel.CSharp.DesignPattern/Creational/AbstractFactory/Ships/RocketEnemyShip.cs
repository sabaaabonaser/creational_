using System;

namespace Ariel.CSharp.DesignPattern.Creational.AbstractFactory.Ships
{
    public class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip()
        {
            Name = "ROcket Enemy Ship";
            Damage = 10.0;
            Speed = 30.0;
            Console.WriteLine($"{Name} has created");
        }
    }
}