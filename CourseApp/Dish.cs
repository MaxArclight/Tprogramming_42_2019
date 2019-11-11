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
                  col: 200)
        {
        }

        public Dish(string name, int rating, string[] engredients, float weight, float col)
        {
            Name = name;
            Rating = rating;
            Engredients = engredients;
            Weight = weight;
            Col = col;
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

        public string[] Engredients { get; set; }

        public float Weight { get; set; }

        public float Col { get; set; }

        public void View()
        {
            Console.WriteLine(Name);
        }
    }
}