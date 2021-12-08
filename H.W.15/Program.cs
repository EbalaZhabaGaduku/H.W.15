using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W._15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression ds = new ArithProgression();
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + ds.getNext());
            Console.WriteLine("\nСбросить");
            ds.Reset();
            GeomProgression db = new GeomProgression();
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Следующее число равно " + db.getNext());
            Console.WriteLine("\nСбросить");
            db.Reset();
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void Reset();

    }
    class ArithProgression : ISeries
    {
        int difference ;
        int start ;
      public ArithProgression()
        {
            Console.WriteLine("Введите старт ");
            difference = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг ");
            start = Convert.ToInt32(Console.ReadLine());
            
        }
        public int getNext()
        {
            difference +=start;
            return difference;
        }
        public void Reset()
        {
            difference = start;
        }
        public void setStart(int x)
        {
            start = x;
            difference = start;
        }

    }
    class GeomProgression:ISeries
    {
        int difference;
        int start;
        public GeomProgression()
        {
            Console.WriteLine("Введите старт ");
            difference = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг ");
            start = Convert.ToInt32(Console.ReadLine());
        }
        public int getNext()
        {
            difference *= start;
            return difference;
        }
        public void Reset()
        {
            difference = start;
        }
        public void setStart(int x)
        {
            start = x;
            difference = start;
        }
    }
}
