using System;

namespace interface_project
{
    public class Marines : Soldier, ISniper
    {
        public string Aim()
        {
            return "Aiming, awaiting order to fire.";
        }

        public string Load()
        {
            return "Loading.";
        }

        public string PullTrigger()
        {
            return "Firing.";
        }

        public override string Speak()
        {
            return "Ooorah!";
        }
    }
}