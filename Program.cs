using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddAttributes addAttributes = new AddAttributes();
            Console.WriteLine("int:"+ addAttributes.PlusTwoVareble(1, 2));
            Console.WriteLine("int double:" + addAttributes.PlusTwoVareble(1,1.2));
            Console.WriteLine("three double:" + addAttributes.PlusTwoVareble(1.2d, 1.3d, 1.4d));
            Console.WriteLine("string plus:" + addAttributes.PlusTwoVareble("hello ", "world"));
            Console.WriteLine("Son va matn: " + addAttributes.PlusTwoVareble(12,"salom"));

        }
    }
    class AddAttributes
    {
        
        public double PlusTwoVareble(int n, double m)
        {
            return n + m;
        }
        public double PlusTwoVareble(double n, double m, double c)
        {
            return n + m + c;
        }
        public string PlusTwoVareble(string n, string m)
        {
            return n + " " + m;
        }
        public string PlusTwoVareble(int n, string m)
        {
            return n.ToString() + " " + m;
        }
        public virtual int PlusTwoVareble(int n, int m)
        {
            return n + m;
        }

    }
   
}