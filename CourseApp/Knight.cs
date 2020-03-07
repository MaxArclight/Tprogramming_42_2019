using System;

namespace CourseApp
{
    public class Knight : Player
    {

        private int maxHP;

        public Knight()
            : this("Untitled")
        {
        }

        public Knight(string name)
            : base(name, isDead, hp)
        {
        }
    }
}