
namespace Ariel.CSharp.DesignPattern.Creational.Builder.RobotDAO
{
    public class Robot : IRobotPlain
    {
        private string m_RobotHead;
        private string m_RobotTorso;
        private string m_RobotArms;
        private string m_RobotLegs;


        public void SetRobotHead(string i_Head)
        {
            this.m_RobotHead = i_Head;
        }

        public void SetRobotTorso(string i_Torso)
        {
            this.m_RobotTorso = i_Torso;
        }
        public void SetRobotArms(string i_Arms)
        {
            this.m_RobotArms = i_Arms;
        }

        public void SetRobotLegs(string i_Legs)
        {
            this.m_RobotLegs = i_Legs;
        }

        public string GetRobotHead()
        {
            return this.m_RobotHead;
        }
        public string GetRobotTorso()
        {
            return this.m_RobotTorso;
        }
        public string GetRobotArms()
        {
            return this.m_RobotArms;
        }
        public string GetRobotLegs()
        {
            return this.m_RobotLegs;
        }
    }
}
