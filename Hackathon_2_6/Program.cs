using Hackathon_2_6.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader("test03.TXT");

            myModel context = new myModel();
            while ((line = file.ReadLine()) != null)
            {
                char[] temp = line.ToCharArray();
                if (checkFirstFormat(temp) == true)
                {
                    string index0_12 = String.Empty;
                    string index13_20 = String.Empty;
                    string index21_28 = String.Empty;

                    for(int i=0;i<temp.Count();i++)
                    {
                        if (i >= 0 && i <= 12)
                        {
                            index0_12 = index0_12 + temp[i];
                        }
                        else if (i >= 13 && i <= 20)
                        {
                            index13_20 = index13_20 + temp[i];
                        }
                        else if (i >= 21 && i <= 28)
                        {
                            index21_28 = index21_28 + temp[i];
                        }
                    }

                   // Console.WriteLine(index0_12 + " " + index13_20 + " " + index21_28);

                    if(index13_20 == "99999999")
                    {
                        DateTable data = new DateTable()
                        {
                            TickNumber = index0_12,
                            FlyingDay = DateTime.MaxValue,
                            Birthday = DateTime.ParseExact(index21_28, "yyyyMMdd", null)
                        };

                        context.DateTable.Add(data);
                        context.SaveChanges();
                    }
                    else
                    {
                        DateTable data = new DateTable()
                        {
                            TickNumber = index0_12,
                            FlyingDay = DateTime.ParseExact(index13_20, "yyyyMMdd", null),
                            Birthday = DateTime.ParseExact(index21_28, "yyyyMMdd", null)
                        };

                        context.DateTable.Add(data);
                        context.SaveChanges();
                    }
                }
            }

            
            var list = context.DateTable.ToList();
            foreach(var l in list)
            {
                Console.WriteLine(l.TickNumber + " " + l.FlyingDay.ToString("yyyy/MM/dd") + " " + l.Birthday.ToString("yyyy/MM/dd"));
            }


            file.Close();
            Console.ReadLine();
        }

        public static bool checkFirstFormat(char[] temp)
        {
            string index0_2 = String.Empty;
            string index13_20 = String.Empty;
            string index21_28 = String.Empty;

            for (int i = 0; i < temp.Count(); i++)
            {
                if (i >= 0 && i <= 2)
                {
                    index0_2 = index0_2 + temp[i];
                }
                else if (i >= 13 && i <= 20)
                {
                    index13_20 = index13_20 + temp[i];
                }
                else if (i >= 21 && i <= 28)
                {
                    index21_28 = index21_28 + temp[i];
                }
            }

            DateTime myDate;

            if ((index0_2 == "695" || index0_2 == "525") &&
                (DateTime.TryParseExact(index13_20, "yyyyMMdd", null, DateTimeStyles.None, out myDate) || index13_20 == "99999999") &&
                DateTime.TryParseExact(index21_28, "yyyyMMdd", null, DateTimeStyles.None, out myDate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
