using System;

namespace Ariel.CSharp.DesignPattern.Creational.AbstractFactory.Ships
{
    public class UfoEnemyShip:EnemyShip
    {
        public UfoEnemyShip()
        {
            Name = "UFO Enemy Ship";
            Damage = 20.0;
            Speed = 20.0;
            Console.WriteLine($"{Name} has created");
        }
    }
}
