using System;

namespace interface_project
{
    public class Army : Soldier, ITankDriver
    {
        public string FireCannon()
        {
            return "Firing cannon!";
        }

        public string GoForward()
        {
            return "Rolling along.";
        }

        public override string Speak()
        {
            return "Over hill, over dale!";
        }

        public string Turn()
        {
            return "Turning.";
        }
    }
}