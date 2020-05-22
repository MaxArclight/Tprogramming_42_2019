using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Player
    {
        private List<string> sampleNames = new List<string>() { "John", "James", "Arthur", "Samplename", "Nick", "Victor" };

        public Player()
        {

            Name = SetName();
            Active = new List<ISpell>();
            Passive = new List<ISpell>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public void SetName()
        {
            Random rnd = new Random();

            this.name = sampleNames[rnd.Next(0, 5)];
        }

        public void SetClassName(string name) { this.className = name; }

        public List<> Active { get; set; }

        public List<> Passive { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public int SetMaxHp() {
            this.hp = 5 + this.strength / 2;
        }

        public int CurrentHp { get; set; }

        public void GetDamage(int dmg) {
            this.CurrentHp = this.CurrentHp - dmg;
        }

        

        public bool IsStunned { get; set; }
    }
}