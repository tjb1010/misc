using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;


namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
             void compareTriplets(List<int> a, List<int> b)
            {
                List<int> result = new List<int> { 0, 0 };

               if (a[0] > b[0])
                {
                    result[0] += 1;
                }
               else if (a[0] < b[0])
                {
                    result[1] += 1;
                }

                if (a[1] > b[1])
                {
                    result[0] += 1;
                }
                else if (a[1] < b[1])
                {
                    result[1] += 1;
                }

                if (a[2] > b[2])
                {
                    result[0] += 1;
                }
                else if (a[2] < b[2])
                {
                    result[1] += 1;
                }

                foreach (int x in result)
                {
                    Console.Write(x + " ");
                }


            }

            var c = new List<int>() { 17, 28, 30};
            var d = new List<int>() { 99 , 16 , 8 };
            compareTriplets(c, d);
            //Video encoder  stuff
            //var video = new Video() { Title = "Video 1" };
            //var videoEncoder = new VideoEncoder(); //publisher
            //var mailService = new MailService(); // subscriber
            //var messageService = new MessageService(); // another subscriber

            //videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //subscription
            //videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // another subscription

            //videoEncoder.Encode(video);


            //var customer = new Customer(5, "Jack");
            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);

            //var person = new Person(new DateTime(1982, 1, 1));
            //Console.WriteLine("This person is " + person.Age);

            ////-------------------
            //int x = 10;
            //int y = 20;

            //Console.WriteLine("x = {0}; y = {1}", x, y);
            //Console.WriteLine("x = " + x + "; " + "y = " + y);

            //Console.WriteLine("What is your name?");

            //var yourName = Console.ReadLine();

            //Console.WriteLine("Hello, {0}", yourName);

            //Console.WriteLine("How old are you?");

            //var age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(age);
            // -------------------



            //var bank = new BankAccount();

            //bank.Deposit(15.99);
            //Console.WriteLine(bank.GetBalance());
            //bank.Deposit(21.50);
            //Console.WriteLine(bank.GetBalance());
            //bank.Withdraw(2.99);
            //Console.WriteLine(bank.GetBalance());
            //bank.Balance = 100.00;
            //Console.WriteLine(bank.Balance);



        }
    }



}
