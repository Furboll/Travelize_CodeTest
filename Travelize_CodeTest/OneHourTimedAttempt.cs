using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelize_CodeTest
{
    public class OneHourTimedAttempt
    {
        public void Solution()
        {
            Console.WriteLine("=== Club Member Registration ===");

            Console.WriteLine("Enter name");
            var Name = Console.ReadLine();

            ValidateName(Name);

            /////Note: slänga exception istället för konsol meddelande??
            //if (Name.Length < 5)
            //{
            //    Console.WriteLine("Name should be 5 characters or more");
            //}



            Console.WriteLine("Enter Birthdate in format yyyyMMdd");
            var Birthdate = Console.ReadLine();
            DateTime? today = DateTime.Today;
            DateTime? parsedDate = null;


            ///No bueno, för mycket i try blocket, behöver brytas ut för att fånga olika saker.??
            try
            {
                parsedDate = DateTime.ParseExact(Birthdate, "yyyyMMdd", CultureInfo.InvariantCulture);
                TimeSpan ts = (TimeSpan)(today - parsedDate);



                if (true)
                {
                    var userData = "placeholder\t";
                    /// adduserdatamethod();
                    /// 


                    ///fix strucuter below
                    var path = @"C:\Users\Furball\Desktop\Desktop";

                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine(userData);
                            sw.Close();
                        }
                    }

                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(userData);
                        sw.Close();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Birtdate format");
                ///Note, slänag tillbaka till början?
            }

            static void ValidateName(string name)
            {
                if (name.Length < 5)
                    throw new ArgumentException("Name must be at least 5 characters long.");
            }

            static void ValidateAge(DateTime birthdate)
            {
                int currentYear = DateTime.Now.Year;
                int birthYear = birthdate.Year;

                if (currentYear - birthYear < 15)
                    throw new ArgumentException("Member must be at least 15 years old.");
            }

            static void SaveMembers()
            {

            }
        }
    }
}
