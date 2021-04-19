using System;
namespace task02
{
    public class GoodPupil : Pupil
    {
        public override void Study() { Console.WriteLine("Good Study"); }
        public override void Read() { Console.WriteLine("Good Read"); }
        public override void Write() { Console.WriteLine("Good Write"); }
        public override void Relax() { Console.WriteLine("Good Relax"); }
    }
}
