
using Ariel.CSharp.DesignPattern.Creational.Builder.RobotBuilder;
using Ariel.CSharp.DesignPattern.Creational.Builder.RobotDAO;

namespace Ariel.CSharp.DesignPattern.Creational.Builder
{
    public class RobotEngineer
    {
        private readonly IRobotBuilder r_RobotBuilder;

        public RobotEngineer(IRobotBuilder i_RobotBuilder)
        {
            this.r_RobotBuilder = i_RobotBuilder;
        }

        public void MakeRobot()
        {
            this.r_RobotBuilder.BuildRobotHead();
            this.r_RobotBuilder.BuildRobotTorso();
            this.r_RobotBuilder.BuildRobotArms();
            this.r_RobotBuilder.BuildRobotLegs();
        }

        public Robot GetRobot()
        {
            return this.r_RobotBuilder.GetRobot();
        }
    }
}
