namespace Thesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice:");
            Console.WriteLine("1. Mentalist \n 2. Mimic Ptolemy \n 3. Calender Man");
            int choice=Convert.ToInt32(Console.ReadLine());

            if (choice ==   1)
            {
                Mentalist();
            }
            if(choice == 2)
            {
                Mimic_Ptolemy();
            }
            if (choice == 3)
            {
                Calender_man();
            }
        }

        public static void Mentalist()
        {
            Console.WriteLine("On the scale of 1 to 5 how extrover are you? ");
            int inex = Convert.ToInt32(Console.ReadLine());
            int mentality_score = 0;
            if (inex < 2)
            {
                Console.WriteLine("You are extreme introvert");
                mentality_score = 1;
            }
            else if (inex < 4)
            {
                Console.WriteLine("You are moderate introvert");
                mentality_score=2;
            }
            else
            {
                Console.WriteLine("You are an extrovert");
                mentality_score = 3;
            }
            Console.WriteLine("On the scale of 1 to 5 how selfish are you? ");
            int self = Convert.ToInt32(Console.ReadLine());
            if (self <= 2)
            {
                Console.WriteLine("You are selfless!!!\n You are Kind and put ourselves on their shoes and act accordingly");
                mentality_score = 3;
            }
            else if (self <= 4)
            {
                Console.WriteLine("You are moderatly selfish");
                mentality_score = 2;
            }
            else
            {
                Console.WriteLine("You are selfish");
                mentality_score = 1;
            }
            Console.WriteLine("On the scale of 1 to 5 how short temper are you? ");
            int self1 = Convert.ToInt32(Console.ReadLine());
            if (self1 <= 3)
            {
                Console.WriteLine("You are Cool person");
                mentality_score = 3;
            }
            else if (self1 == 4)
            {
                Console.WriteLine("You are moderatly practical ");
                mentality_score = 2;
            }
            else
            {
                Console.WriteLine("You are tempered person");
                mentality_score = 1;
            }
            if (mentality_score > 4)
            {
                Console.WriteLine("You are Mentally strong person");
            }
            else
            {
                Console.WriteLine("You are Mentally weak person");
            }
        }
        public static void Mimic_Ptolemy()
        {
            string astro_sign = "";
            Console.WriteLine("Enter Your Day you are born:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Month you born:");
            string month = Console.ReadLine();
            month= month.ToLower();

            if (month == "december")
            {

                if (day < 22)
                    astro_sign = "Sagittarius";
                else
                    astro_sign = "capricorn";
            }

            else if (month == "january")
            {
                if (day < 20)
                    astro_sign = "Capricorn";
                else
                    astro_sign = "aquarius";
            }

            else if (month == "february")
            {
                if (day < 19)
                    astro_sign = "Aquarius";
                else
                    astro_sign = "pisces";
            }

            else if (month == "march")
            {
                if (day < 21)
                    astro_sign = "Pisces";
                else
                    astro_sign = "aries";
            }
            else if (month == "april")
            {
                if (day < 20)
                    astro_sign = "Aries";
                else
                    astro_sign = "taurus";
            }

            else if (month == "may")
            {
                if (day < 21)
                    astro_sign = "Taurus";
                else
                    astro_sign = "gemini";
            }

            else if (month == "june")
            {
                if (day < 21)
                    astro_sign = "Gemini";
                else
                    astro_sign = "cancer";
            }

            else if (month == "july")
            {
                if (day < 23)
                    astro_sign = "Cancer";
                else
                    astro_sign = "leo";
            }

            else if (month == "august")
            {
                if (day < 23)
                    astro_sign = "Leo";
                else
                    astro_sign = "virgo";
            }

            else if (month == "september")
            {
                if (day < 23)
                    astro_sign = "Virgo";
                else
                    astro_sign = "libra";
            }

            else if (month == "october")
            {
                if (day < 23)
                    astro_sign = "Libra";
                else
                    astro_sign = "scorpio";
            }

            else if (month == "november")
            {
                if (day < 22)
                    astro_sign = "scorpio";
                else
                    astro_sign = "sagittarius";
            }

            Console.WriteLine(astro_sign);
            
        }

        public static void Calender_man()
        {
            var birthday = new DateTime();
            Console.WriteLine("Enter your DOB as year,month, day");
            birthday = Convert.ToDateTime( Console.ReadLine());
            var age = DateTime.Now.Year - birthday.Year;
            Console.WriteLine(age);
        }

    }
        
    }


