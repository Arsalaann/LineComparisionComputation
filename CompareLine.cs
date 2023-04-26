using System;
namespace LineComparisionComputation{
    public class CompareLine{
        private static int Pow(int num){
            return num*num;
        }
        public static void Compare(){
            int x1,y1,x2,y2;
            int X1,Y1,X2,Y2;
            Random rnd=new Random();
            x1=rnd.Next(10);
            y1=rnd.Next(10);
            x2=rnd.Next(10);
            y2=rnd.Next(10);
            X1=rnd.Next(10);
            Y1=rnd.Next(10);
            X2=rnd.Next(10);
            Y2=rnd.Next(10);
            int Lth1=Convert.ToInt32(Math.Sqrt(Pow(Math.Abs(x2-x1))+Pow(Math.Abs(y2-y1))));
            int Lth2=Convert.ToInt32(Math.Sqrt(Pow(Math.Abs(X2-X1))+Pow(Math.Abs(Y2-Y1))));
            Console.WriteLine("Line one Length : "+Lth1);
            Console.WriteLine("Line two Length : "+Lth2);
            if(Lth1==Lth2)
                Console.WriteLine("Both Lines are Equal");
            else if(Lth1>Lth2)
                Console.WriteLine("Line 1 is greater than line 2");
            else
                Console.WriteLine("Line 2 is greater than line 1");
        }
    }
}