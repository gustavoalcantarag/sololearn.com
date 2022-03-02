//using System;
//using System.Collections.Generic;


//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int pay = Convert.ToInt32(Console.ReadLine());

            Payment pay1 = new Payment();
            pay1.PaymentValue = pay;
        }
    }

    class Payment
    {
        public int paymentValue;

        //complete the property
        public int PaymentValue
        {
            get { return paymentValue; }
            set
            {
                paymentValue = value;
                if(paymentValue <= 50000)
                {
                    Console.WriteLine("Accepted");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}