//using System;
//using System.Collections.Generic;


//namespace sololearn
//{
//    class program
//    {
//        static void main(string[] args)
//        {
//            int number = Convert.ToInt32(Console.ReadLine());
//            string value = "";

//            for (int i = 1; i <= number; i++)
//            {
//                if (i % 3 == 0)
//                {
//                    value = "*";
//                }
//                value = value + i.ToString();
//            }
//            Console.WriteLine(value);
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //create a Welcome object with the same name
//            Welcome test = new Welcome();

//            test.WelcomeMessage();
//        }
//    }

//    class Welcome
//    {

//        //complete the class, add WelcomeMessage() method
//        public void WelcomeMessage()
//        {

//            Console.WriteLine("Welcome to OOP");
//        }

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int games = Convert.ToInt32(Console.ReadLine());
//            int wins = Convert.ToInt32(Console.ReadLine());

//            //creating the player object
//            Player player1 = new Player();

//            player1.games = games;
//            player1.wins = wins;

//            //output
//            player1.GetWinRate();
//        }
//    }

//    class Player
//    {
//        public int games;
//        public int wins;
//        //winrate is private
//        private int winrate;

//        //complete the method
//        public void GetWinRate()
//        {
//            winrate = wins * 100 / games;
//            Console.WriteLine(winrate);
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string name = Console.ReadLine();
//            string phoneNumber = Console.ReadLine();

//            User user1 = new();
//            user1.ShowDetails(name, phoneNumber);
//        }
//    }
//    class User
//    {

//        //complete the constructor
//        public User()
//        {

//            Console.WriteLine("Profile is created");
//        }
//        public void ShowDetails(string userName, string phoneNumber)
//        {
//            Console.WriteLine("Name: " + userName);
//            Console.WriteLine("Phone number: " + phoneNumber);
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Card card1 = new Card();

//            //fix the output
//            Console.WriteLine(card1.accountNum);
//        }
//    }
//    class Card
//    {

//        public string accountNum
//        {
//            get { return "0011592048120"; }
//        }
//        //create a property to get the account

//    }
//}


//namespace SoloLearn
//{
//    class Program
//    {
//        class Person
//        {
//            public string Name { get; set; }
//        }
//        static void Main(string[] args)
//        {
//            Person p = new Person();
//            p.Name = "Bob";
//            Console.WriteLine(p.Name);
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int pay = Convert.ToInt32(Console.ReadLine());

//            Payment pay1 = new Payment();
//            pay1.PaymentValue = pay;
//        }
//    }

//    class Payment
//    {
//        public int paymentValue;

//        //complete the property
//        public int PaymentValue
//        {
//            get { return paymentValue; }
//            set
//            {
//                paymentValue = value;
//                if(paymentValue <= 50000)
//                {
//                    Console.WriteLine("Accepted");
//                }
//                else
//                {
//                    Console.WriteLine("Error");
//                }
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//namespace Code_Coach_Challenge
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string postText = Console.ReadLine();

//            Post post = new Post();
//            post.Text = postText;
//            post.ShowPost();

//        }
//    }

//    class Post
//    {
//        private string text;

//        //write a constructor here
//        public Post()
//        {
//            text = Text;
//        }

//        public void ShowPost()
//        {
//            Console.WriteLine("New post");
//            Console.WriteLine(text);
//        }

//        //write a property for member text
//        public string Text
//        {
//            get { return text; }
//            set { text = value; }
//        }

//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//            for (int k = 0; k < 3; k++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    Console.Write(num[k, j] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int count = 0;
//            int number;
//            int[] array = new int[5];
//            while (count < 5)
//            {
//                number = Convert.ToInt32(Console.ReadLine());
//                array[count] = number;
//                count++;
//            }

//            Console.WriteLine(array.Max() + array.Min());

//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string password = Console.ReadLine();
//            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')',
//            '*', ',', '+', '-' };

//            for (int i = 0; i < notAllowedSymbols.Length; i++)
//            {
//                for (int e = 0; e < password.Length; e++)
//                {
//                    if (notAllowedSymbols.Contains(password[e]))
//                    {
//                        Console.WriteLine("Invalid");
//                        break;
//                    }
//                }
//                break;
//            }

//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };

//            int winner = Convert.ToInt32(Console.ReadLine());

//            //this should show the winner and "Game Over"
//            FinalRound finalRound = new FinalRound(finalists, winner);
//        }
//    }

//    class FinalRound
//    {
//        public FinalRound(string[] finalists, int winner)
//        {
//            //complete the constructor
//            Console.WriteLine("Winner is " + finalists[winner]);
//        }

//        //create destructor => "Game Over"
//         ~FinalRound()
//        {
//            //complete the constructor
//            Console.WriteLine("Game Over");
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int numOfDeps = Convert.ToInt32(Console.ReadLine());

//            int count = 0;
//            while (count < numOfDeps)
//            {
//                string depName = Console.ReadLine();
//                Department dep = new Department(depName);
//                count++;
//            }

//            Console.WriteLine("Number of departments: " + Department.depCount);
//        }
//    }
//    class Department
//    {

//        public string depName;

//        //declare static depCount member with value of 2
//        public static int depCount = 2;

//        //complete the constructor
//        public Department(string name)
//        {
//            Console.WriteLine("Departm  ent opened: " + name);
//            this.depName = name;
//            depCount++;
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int count = Convert.ToInt32(Console.ReadLine());

//            int[] numbers = new int[count];

//            for (int i = 0; i < count; i++)
//            {
//                numbers[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            Array.Sort(numbers);
//            for(int i = 0; i < count; i++)
//            {
//                Console.WriteLine(numbers[i]);
//            }

//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double num1 = Convert.ToDouble(Console.ReadLine());
//            double num2 = Convert.ToDouble(Console.ReadLine());

//            Avg avg = new Avg(num1, num2);

//            Console.WriteLine(avg.GetAvg());
//        }
//    }

//    class Avg
//    {
//        double num1;
//        double num2;

//        public Avg(double number1, double number2)
//        {
//            this.num1 = number1;
//            this.num2 = number2;
//        }


//    public double GetAvg()
//        {
//            return (num1 + num2) / 2;
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MusicGenres genres = new MusicGenres();

//            int count = 0;
//            while (count < 5)
//            {
//                genres[count] = Console.ReadLine();
//                count++;
//            }

//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Following: " + genres[i]);
//            }
//        }
//    }
//    class MusicGenres
//    {
//        private string[] genres = new string[5];

//        public string this[int index]
//        {
//            get
//            {
//                return genres[index];
//            }
//            set
//            {
//                genres[index] = value;
//            }
//        }

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SoloLearn
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Score tm1 = new Score(2, 3);
//            Score tm2 = new Score(4, 2);

//            Score finalScores = tm1 + tm2;


//            Console.WriteLine("Round 1: " + finalScores.round1Score);
//            Console.WriteLine("Round 2: " + finalScores.round2Score);
//        }
//    }
//    class Score
//    {
//        public int round1Score { get; set; }
//        public int round2Score { get; set; }
//        public Score(int r1, int r2)
//        {
//            round1Score = r1;
//            round2Score = r2;
//        }

//        public static Score operator +(Score a, Score b)
//        {
//            int h = a.round1Score + b.round1Score;
//            int w = a.round2Score + b.round2Score;
//            Score res = new Score(h, w);
//            return res;
//        }
//    }
//}

using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }

    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //overload the + operator
        public static DancerPoints operator +(DancerPoints a, DancerPoints b)
        {
            
            int w = a.points + b.points;
            string h = a.name +" & "+ b.name;
            DancerPoints res = new DancerPoints(h,w);
            return res;
        }
    }
}