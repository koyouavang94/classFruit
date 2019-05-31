using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    //parent class
    public class fruit
    {
        //properties
        public string _color { set; get; }
        public string _flavor { set; get; }

        //constructor
        public fruit(string color, string flavor)
        {
            //equating to parameter
            _color = color;
            _flavor = flavor;

            Console.WriteLine("Fruit has come to fruition!");
            Console.WriteLine("The apple's color is {0} and it tastes {1}", color, flavor);
        }

        //method for parent class
        public void buy(int buy1)
        {
            for (int i = 0; i < buy1; i++)
                Console.WriteLine("All of the apples in the store are {0}", _color);

            for (int i = 0; i < buy1; i++)
                Console.WriteLine("All of the apples my apples are {0}", _flavor);
        }

    }

    //subclass
    public class apple : fruit
    {
        //property
        public float _weight { set; get; }
        public string _size { set; get; }

        //constructor
        public apple(string color, string flavor, float weight, string size) : base(color, flavor)
        {
            //equate property to parameter
            _weight = weight;
            _size = size;

            Console.WriteLine("this apple's color is {0} and it weighs {1} oz and it's size is {2}", color, weight, size);
        }

        //method for subclass
        public void action(string action1)
        {
            Console.WriteLine("The apple is {0} on the floor", action1);
        }
    }
}