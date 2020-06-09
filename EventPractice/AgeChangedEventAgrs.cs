using System;

namespace EventPractice
{
    public class AgeChangedEventAgrs:EventArgs
    {
        private int _oldAge;
        private int _newAge;

        public int OldAge
        {
            get => _oldAge;
            set => _oldAge = value;
        }

        public int NewAge
        {
            get => _newAge;
            set => _newAge = value;
        }

        public AgeChangedEventAgrs(int oldAge, int newAge)
        {
            _oldAge = oldAge;
            _newAge = newAge;
        }
    }
    
}