using System;

namespace interface_project
{
    public class AirForce : Soldier, IPilot
    {
        public string Cruise()
        {
            return "Cruising at 38,000 feet.";
        }

        public string Land()
        {
            return "Approaching runway 19 for landing.";
        }

        public override string Speak()
        {
            return "Off we go into the Wild Blue Yonder!";
        }

        public string Takeoff()
        {
            return "Cleared for takeoff.  Here we go!";
        }
    }
}