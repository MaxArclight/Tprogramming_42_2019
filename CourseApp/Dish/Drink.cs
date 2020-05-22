using System;

namespace CourseApp
{
    public class Drink : Food
    {
        private double volume;

        public Drink()
        : this(0, "Untitled", true)
        {
        }

        public Drink(int rating, string name, bool isReady)
            : base(name, rating, isReady)
        {
            Name = name;
            Rating = rating;
            IsReady = isReady;
        }

        public double Volume
        {
            get
            {
                return this.volume;
            }

            set
            {
                if (value >= 0)
                {
                    this.volume = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Weight should be > 0");
                }
            }
        }
    }
}