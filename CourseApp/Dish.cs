using System;

namespace CourseApp
{
    public class Dish : Food
    {
        public Dish()
        : this(0, "Untitled", true)
        {
        }

        public Dish(int rating, string name, bool isReady)
        {
            Name = name;
            Rating = rating;
            IsReady = isReady;
        }

        public bool Cook()
        {
            this.IsReady = true;
            return this.IsReady;
        }
    }
}