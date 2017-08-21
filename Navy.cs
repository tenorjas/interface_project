using System;

namespace interface_project
{
    public class Navy : Soldier, ISail
    {
        public string AllStop()
        {
            return "Answering all stop, sir.";
        }

        public string FireTorpedo()
        {
            return "Firing torpedo.";
        }

        public string FullAhead()
        {
            return "Full speed ahead!";
        }

        public override string Speak()
        {
            return "Anchors aweigh!";
        }
    }
}