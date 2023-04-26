using System;
namespace LineComparisionComputation{
    public class CompareLine{
        private static int Pow(int num){
            return num*num;
        }
        private static bool CheckEquality(int L1,int L2){
            return L1==L2;
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
            if(CheckEquality(Lth1, Lth2))
                Console.WriteLine("Line are Equal");
            else
                Console.WriteLine("Line are not Equal");
        }
    }
}