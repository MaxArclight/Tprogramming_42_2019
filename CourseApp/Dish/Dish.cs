using System;

namespace CourseApp
{
    public class Dish : Food
    {
        public Dish()
        : this("Untitled", 1, true)
        {
        }

        public Dish(string name, int rating, bool isReady)
            : base(name, rating, isReady)
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