using System;

namespace ClassyHW
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Animal("Maisem");
            animal1.Move("slowly");

            var cat1 = new Cat("Heathcliff", false);
            cat1.CatAttack();
            cat1.Move("Up");
        }

        
    }

    class Animal
    {
        public string _name { get; set; }
        public Animal(string name)
        {
            Console.WriteLine("Animal created!");
            _name = name;
        }

        public void MakeNoise()
        {
            Console.WriteLine("noise made");
        }

        public void Move(string direction)
        {
            Console.WriteLine("Animal moved {0}", direction);
        }
    }

    class Dog : Animal
    {
        public string _breed { get; set; }
        public Dog(string name, string breed) : base(name)
        {
            _name = name;
            _breed = breed;
        }

        public void WhatIsBreed()
        {
            Console.WriteLine("Breed is {0}", _breed);
        }
    }

    class Cat : Animal
    {
        public bool _isSixToe { get; set; }

        public Cat(string name, bool isSixToe) : base(name)
        {
            _name = name;
            _isSixToe = isSixToe;
        }

        public void CatAttack()
        {
            Console.WriteLine("Cat Attacks with...");
            if (_isSixToe)
            {
                Console.WriteLine("...six toes!");
            } else
            {
                Console.WriteLine("...five toes!");
            }
        }
    }

}
