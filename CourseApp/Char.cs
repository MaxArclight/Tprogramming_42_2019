using System;

namespace CourseApp
{
    public class Player
    {
        private bool isDead;
        private int hp;

        public Player(string name, bool isDead, int hp)
        {
            Hp = hp;
            Name = name;
            IsDead = isDead;
        }

        public string Name { get; set; }

        public bool IsDead { get; set; }

        public int Hp { get; set; }

    }
}