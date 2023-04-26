using System;
namespace LineComparisionComputation{
    public class CompareLine{
        private static int Pow(int num){
            return num*num;
        }
        public static void Compare(){
            int x1,y1,x2,y2;
            Random rnd=new Random();
            x1=rnd.Next(10);
            y1=rnd.Next(10);
            x2=rnd.Next(10);
            y2=rnd.Next(10);
            int Lth=Convert.ToInt32(Math.Sqrt(Pow(Math.Abs(x2-x1))+Pow(Math.Abs(y2-y1))));
            Console.WriteLine("Length is: "+Lth);
        }
    }
}