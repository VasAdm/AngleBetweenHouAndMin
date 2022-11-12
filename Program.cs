using System;
using System.ComponentModel.Design.Serialization;

namespace AngleBetweenHouAndMin
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Который час? 'Час.мин'");
            text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
            int hours = int.Parse(words[0]);
            int minutes = int.Parse(words[1]);
            Console.WriteLine("Угол " + Angle(hours, minutes) + "градусов.");
            Console.ReadKey();
        }
        static int Angle(int hours, int minutes)
        {
            int angle;
            if ( hours % 12 == 0 ) hours = 0;
            if (minutes % 60 == 0) minutes = 0;
            if (hours * 30 > minutes * 6) angle = hours * 30 - minutes * 6;
            else if (hours * 30 < minutes * 6) angle = minutes * 6 - hours * 30;
            else angle = 0;
            return angle;
        }
    }
}
