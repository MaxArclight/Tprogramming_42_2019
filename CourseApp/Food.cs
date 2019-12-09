using System;

namespace CourseApp
{
    public class Food
    {
        private int rating;
        private double weight;
        private double cal;

        public Food()
        : this(0, "Untitled", true)
        {
        }

        public Food(int rating, string name, bool isReady)
        {
            Name = name;
            Rating = rating;
            IsReady = isReady;
        }

        public string Name { get; set; }

        public bool IsReady { get; set; }

        public int Rating
        {
            get
            {
                return this.rating;
            }

            set
            {
                if (value >= 0 && value < 100)
                {
                    this.rating = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Rating should be > 0 and < than 100");
                }
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }

            set
            {
                if (value >= 0)
                {
                    this.weight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Weight should be > 0");
                }
            }
        }

        public double Cal
        {
            get
            {
                return this.cal;
            }

            set
            {
                if (value >= 0)
                {
                    this.cal = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Calories should be > 0");
                }
            }
        }
    }
}