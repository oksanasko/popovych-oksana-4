// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    interface IBirdable
    {
        protected int _Age { get; set; }
        protected int _Speed { get; set; }
        void Move();
        string Food();
        void GetFood();
    }
    //abstract class Bird : IBirdable
    //{
    //    protected int _Age;
    //    protected int _Speed;
    //    public abstract string Food();
    //    public abstract void GetFood();
    //    public abstract void Move();
    //    public int GetAge()
    //    {
    //        return _Age;
    //    }
    //}
    abstract class Flying : IBirdable  
    {
        public int _Speed { get; set; }
        public int _Height { get; set; }
        public int _Age { get; set ; }
        public virtual string Food()
        {
           return Food();
        }
        public virtual void GetFood() { }
        public void Move()
        {
            Console.WriteLine($"I can fly {_Speed} km/h on {_Height} m height, so I do");
        }
    }
    abstract class notFlying : IBirdable
    {
        public int _Speed { get; set; }
        public int _Age { get; set; }
        public virtual string Food()
        {
            return Food();
        }
        public virtual void GetFood() { }
        public virtual void Move()
        {
            Console.WriteLine($"I can not fly, so I ran {_Speed} km/h");
        }
    }
    class Eagle : Flying
    {
        public Eagle(int age)
        {
           _Age = age > 30 ? age : 30;
           _Speed = 150;
           _Height = 7000; 
           Console.WriteLine($"I am a {_Age} years old eagle");
        } 
        public override string Food()
        {
            return "rabbits, fish, birds";
        }

        public override void GetFood()
        {
            Move();
            Console.WriteLine($"I hunt on {Food()}");
        }
    }
    class Parrot : Flying
    {
        public Parrot(int age, string name)
        {
            _Age = age > 50 ? age : 50;
            _Name = name;
            _Speed = 50;
            _Height = 50;
            Console.WriteLine($"I am {_Name}, a {_Age} years old parrot");
        }
        public override string Food()
        {
            return "fresh vegetables, fruits and pellets or seeds";
        }

        public override void GetFood()
        {
            Move();
            Console.WriteLine($"I seatch for {Food()}");
        }
        public void Speak()
        {
            Console.WriteLine($"{_Name} wants to eat {Food()}");
        }
        private string _Name;
    }
    class Ostrich : notFlying
    {
        public Ostrich (int age)
        {
            _Age = age > 35 ? age : 35;
            _Speed = 70;
            Console.WriteLine($"I am a {_Age} years old ostrich");
        }
        public override string Food()
        {
            return "plants, fruits, insects";
        }
        public override void GetFood()
        {
            Move();
            Console.WriteLine($"I find or catch {Food()}");
        }
        public void Hide()
        {
            Console.WriteLine("Head is under sand");
        }
    }
    class Penguin : notFlying
    {
        public Penguin(int age)
        {
            _Age = age > 20 ? age : 20;
            _Speed = 8;
            Console.WriteLine($"I am a {_Age} years old penguin");
        }
        public override string Food()
        {
            return "fishes, krill, squids";
        }
        public override void GetFood()
        {
            Move();
            Console.WriteLine($"I catch {Food()}");
        }
        public override void Move()
        {
            Console.WriteLine($"I can not fly, so I swim {_Speed} km/h");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Eagle eagle = new Eagle(3);
            eagle.GetFood();
            Console.WriteLine();

            Parrot parrot = new Parrot(10, "Kescha");
            parrot.GetFood();
            parrot.Speak();
            Console.WriteLine();

            Ostrich ostrich = new Ostrich(6);
            ostrich.GetFood();
            ostrich.Hide();
            Console.WriteLine();

            Penguin penguin = new Penguin(4);
            penguin.GetFood();

        }
    }
}

