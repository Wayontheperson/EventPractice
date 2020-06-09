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

        public delegate void AgeChangedHandeler(object sender, EventArgs e);

        public event AgeChangedHandeler AgeChanged;

        public void IncreaseAge()
        {
            int oldage = _age;
            _age++;
            if (AgeChanged != null)
                AgeChanged(oldage, _age);
        }
        
    }
}