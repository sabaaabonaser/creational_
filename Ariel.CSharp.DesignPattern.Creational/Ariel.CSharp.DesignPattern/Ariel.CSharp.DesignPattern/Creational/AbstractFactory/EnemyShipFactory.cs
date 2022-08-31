using Ariel.CSharp.DesignPattern.Creational.AbstractFactory.Ships;

namespace Ariel.CSharp.DesignPattern.Creational.AbstractFactory
{
    public class EnemyShipFactory
    {

        public EnemyShip MakeEnemyShip(string i_NewShipType)
        {
            if(i_NewShipType == "U")
            {
                return new UfoEnemyShip();
            }
            if(i_NewShipType == "R")
            {
                return new RocketEnemyShip();
            }
            if(i_NewShipType == "B")
            {
                return new BigUfoShip();
            }
            else
            {
                return null;
            }
        }

        
    }
}
