using System;

namespace EventPractice
{
    class Program
    {
         //이럴경우 instant가 static에 접근하는 것이 아닌
                                //private static void Person_AgeChanged가 int birth에 접근하는것
                                //즉 static->instant 인 상황 에러 없애려면 
                                //private static int birth
                                //private  void Person_AgeChanged(int oldage, int newage)
                                //으로 바꿔야 되는데 이러면 private  void Person_AgeChanged(int oldage, int newage)을 메인함수가 못읽음
        static void Main(string[] args)
        {
            Peson peson = new Peson(32,"김과장");
           // peson.AgeChanged=new Peson.AgeChangedDelgate(Person_AgeChanged);
           peson.AgeChanged = Person_AgeChanged; //new AgechangedDelegate(Person_AgeChanged)
           peson.IncreaseAge();
        }
    
        private static void Person_AgeChanged(int oldage, int newage)
        {
            int birth = 11;
            // int birthYear = 1976;
            Console.WriteLine($"{oldage} -> {newage} : {birth}년생 ");
        }
    }
}
