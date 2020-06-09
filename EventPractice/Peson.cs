using System;
using System.Dynamic;

namespace EventPractice
{
    public class Peson
    {
        private int _age;

        public int Age { get; set; }
        
        private string _name;
        
        public string _Name { get; set; }

        public Peson(int age, string name)
        {
            _age = age;
            _name = name;
        }

        // public void IncreaseAge()
        // {
        //     _age++;
        //     Console.WriteLine($"{oldage} -> {_age} ");
        // }

        public delegate void AgeChangedDelgate(int oldage, int newAge);

        public AgeChangedDelgate AgeChanged;

        public void IncreaseAge()
        {
            int oldage = _age;
            _age++;
            if (AgeChanged != null)
                AgeChanged(oldage, _age);
        }

        public event AgeChangedEventHandler AgeChanged;
        
        public void 


    }
}