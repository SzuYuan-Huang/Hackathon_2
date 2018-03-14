using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_2_7
{
    class Program
    {
        static Dictionary<char, PrintLed> print;
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            char[] temp = number.ToCharArray();
            GetData();
            string top = String.Empty;
            string middle = String.Empty;
            string down = String.Empty;


            for (int i=0;i<temp.Count();i++)
            {
                var list = print.Where((x) => x.Key == temp[i]);
                foreach(var l in list)
                {
                    top += l.Value.Top;
                    middle += l.Value.Middle;
                    down += l.Value.Down;
                }
            }

            Console.WriteLine(top + Environment.NewLine + middle + Environment.NewLine + down);
            
            Console.ReadLine();
        }

        public static void GetData()
        {
            print = new Dictionary<char, PrintLed>();

            print.Add('1',new PrintLed
            {
                Top = "   ",
             Middle = " | ",
               Down = " | "
            });
            print.Add('2', new PrintLed
            {
                Top = " _ ",
             Middle = " _|",
               Down = "|_ "
            });
            print.Add('3', new PrintLed
            {
                Top = " _ ",
             Middle = " _|",
               Down = " _|"
            });
            print.Add('4', new PrintLed
            {
                Top = "   ",
             Middle = "|_|",
               Down = "  |"
            });
            print.Add('5', new PrintLed
            {
                Top = " _ ",
             Middle = "|_ ",
               Down = " _|"
            });
            print.Add('6', new PrintLed
            {
                Top = " _ ",
             Middle = "|_ ",
               Down = "|_|"
            });
            print.Add('7', new PrintLed
            {
                Top = " _ ",
             Middle = "| |",
               Down = "  |"
            });
            print.Add('8', new PrintLed
            {
                Top = " _ ",
             Middle = "|_|",
               Down = "|_|"
            });
            print.Add('9', new PrintLed
            {
                Top = " _ ",
             Middle = "|_|",
               Down = " _|"
            });
            print.Add('0', new PrintLed
            {
                Top = " _ ",
             Middle = "| |",
               Down = "|_|"
            });
        }
    }

    public class PrintLed
    {
        public string Top { get; set; }
        public string Middle { get; set; }
        public string Down { get; set; }
    }

}
