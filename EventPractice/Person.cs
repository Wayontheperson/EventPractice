using System;
using System.ComponentModel.Design;
using System.Dynamic;

namespace EventPractice
{
    public class Person
    {
        private int _age;

        public int Age { get; set; }
        
        private string _name;
        
        public string _Name { get; set; }

        public Person(int age, string name)
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

        public event EventHandler<AgeChangedEventAgrs> AgeChanged;

        public void IncreaseAge()
        {
            int oldAge = _age;
            _age++;
            if (AgeChanged != null)
                AgeChanged(this,new AgeChangedEventAgrs(oldAge,_age));
        }
        
    }
}