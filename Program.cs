using System;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var human1 = new Human("Pepe", 10);
            human1.Walk();

            human1.Speak("I like candy!");

            var human2 = new Human("Khalil", 1000);
            human2.Think(23f, 24f);

            var superhuman1 = new SuperHuman("SpiderGuy", 25000, "Web Stuff");
            superhuman1.powerName();
            superhuman1.Speak("I like fighting crime");
        }
    }

    class Human
    {
        public string _name { get; set; }
        public int _hp { get; set; }
        public Human(string name, int hp)
        {
            _name = name;
            _hp = hp;
        }

        public void Walk()
        {
            Console.WriteLine("I am walking");
        }

        public void Speak(string words)
        {
            Console.WriteLine("My name is {0}", _name);
            Console.WriteLine(words);
        }

        public void Think(float num1, float num2)
        {
            var outcome = (num1 * num2) / 5;
            Console.WriteLine("The outcome is: {0}", outcome);
        }
    }

    class SuperHuman : Human
    {
        public string _powerName { get; set; }
        public SuperHuman(string name, int hp, string powerName) : base(name, hp)
        {
            _name = name;
            _hp = hp;
            _powerName = powerName;
        }

        public void powerName()
        {
            Console.WriteLine("Super power is: {0}", _powerName);
        }
    }

}
