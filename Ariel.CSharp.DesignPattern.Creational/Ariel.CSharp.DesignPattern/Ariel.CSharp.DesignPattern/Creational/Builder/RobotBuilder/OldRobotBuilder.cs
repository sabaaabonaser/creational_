
using Ariel.CSharp.DesignPattern.Creational.Builder.RobotDAO;

namespace Ariel.CSharp.DesignPattern.Creational.Builder.RobotBuilder
{
    public class OldRobotBuilder : IRobotBuilder
    {
        private readonly Robot r_Robot;

        public OldRobotBuilder()
        {
            this.r_Robot = new Robot();
        }

        public void BuildRobotArms()
        {
            this.r_Robot.SetRobotArms("Tin Arms");
        }

        public void BuildRobotHead()
        {
            this.r_Robot.SetRobotHead("Tin Head");
        }

        public void BuildRobotLegs()
        {
            this.r_Robot.SetRobotLegs("Tin Legs");
        }

        public void BuildRobotTorso()
        {
            this.r_Robot.SetRobotTorso("Tin Torso");
        }

        public Robot GetRobot()
        {
            return this.r_Robot;
        }
    }
}
