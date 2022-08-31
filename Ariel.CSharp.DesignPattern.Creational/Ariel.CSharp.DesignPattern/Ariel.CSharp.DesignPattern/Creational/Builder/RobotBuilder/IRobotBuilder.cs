
using Ariel.CSharp.DesignPattern.Creational.Builder.RobotDAO;

namespace Ariel.CSharp.DesignPattern.Creational.Builder.RobotBuilder
{
    public interface IRobotBuilder
    {
        void BuildRobotHead();
        void BuildRobotTorso();
        void BuildRobotArms();
        void BuildRobotLegs();

        Robot GetRobot();
    }
 }
