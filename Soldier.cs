using System;

namespace interface_project
{
    public abstract class Soldier
    {
        public string name {get; set;}
        public string rank {get; set;}
        public int serialNumber {get; set;}

        public string Sleep()
        {
            return "Zzz";
        }

        public string Eat()
        {
            return "Yum yum yum!";
        }

        public string Walk()
        {
            return "Ambling along...";
        }

        public abstract string Speak();
        
    }
}