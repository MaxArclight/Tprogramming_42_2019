using System;

namespace CourseApp
{
    public class Dish
    {
        private int rating;

        public Dish()
            : this(
                  name: "Something",
                  rating: 0,
                  engredients: new string[] { "Sugar", "Milk", "Salt", "Eggs" },
                  weight: 500,
                  col: 200,
                  ready: true)
        {
        }

        public Dish(string name, int rating, string[] engredients, float weight, float col, bool ready)
        {
            Col = 0;
            Weight = 0;
            Name = name;

            Rating = rating;
            Engredients = engredients;
            IsReady = ready;

            if (col > 0)
            {
                Col = col;
            }

            if (weight > 0)
            {
                Weight = weight;
            }
        }

        public string Name { get; set; }

        public int Rating
        {
            get
            {
                return this.rating;
            }

            set
            {
                if (value >= 0 && value < 10)
                {
                    this.rating = value;
                }
                else
                {
                    Console.WriteLine("Rating should be > 0 and < than 20");
                }
            }
        }

        public bool IsReady { get; set; }

        public string[] Engredients { get; set; }

        public float Weight
        {
            get
            {
                return this.Weight;
            }

            set
            {
                if (value >= 0)
                {
                    this.Weight = value;
                }
                else
                {
                    this.Weight = 0;
                }
            }
        }

        public float Col { get; set; }

        public void View()
        {
            Console.WriteLine(Name);
        }
    }
}