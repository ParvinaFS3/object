using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace learnapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Person person1 = new Person("John", "Doe", 25);
             Person person2 = new Person("Jane", "Smith", 16);

             Console.WriteLine($"{person1.Name} {person1.Surname}, Yaşı: {person1.Age}, Yetkin: {person1.IsAdult}");
             Console.WriteLine($"{person2.Name} {person2.Surname}, Yaşı: {person2.Age}, Yetkin: {person2.IsAdult}");*/






            /*Car car1 = new Car("Toyota", "Camry", 2022, 120, 5);
            Motorcycle bike1 = new Motorcycle("Honda", "CBR", 2021, 130, false);

            car1.CheckSpeed();
            bike1.CheckSpeed();*/




            User user1 = new User("JohnDoe", "P@ssw0rd");
            User user2 = new User("JaneSmith", "Secret");

            Console.WriteLine($"User 1, Password Valid: {user1.IsPasswordValid()}");
            Console.WriteLine($"User 2, Password Valid: {user2.IsPasswordValid()}");






        }

        /*class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public bool IsAdult { get; set; }

            public Person(string name, string surname, int age)
            {
                Name = name;
                Surname = surname;
                Age = age;
                IsAdult = age >= 18;
            }
        }*/
        /* class Car
         {
             public string Brand { get; set; }
             public string Model { get; set; }
             public int Year { get; set; }
             public int MaxSpeed { get; set; }
             public int NumSeats { get; set; }

             public Car(string brand, string model, int year, int maxSpeed, int numSeats)
             {
                 Brand = brand;
                 Model = model;
                 Year = year;
                 MaxSpeed = maxSpeed;
                 NumSeats = numSeats;
             }
             public void CheckSpeed()
             {
                 if (MaxSpeed > 110)
                 {
                     Console.WriteLine("Sürət öldürür");
                 }
                 else
                 {
                     Console.WriteLine("Belə davam edin");
                 }
             }
         }


         class Motorcycle
             {
                 public string Brand { get; set; }
                 public string Model { get; set; }
                 public int Year { get; set; }
                 public int MaxSpeed { get; set; }
                 public bool HasSidecar { get; set; }

                 public Motorcycle(string brand, string model, int year, int maxSpeed, bool hasSidecar)
                 {
                     Brand = brand;
                     Model = model;
                     Year = year;
                     MaxSpeed = maxSpeed;
                     HasSidecar = hasSidecar;
                 }

                 public void CheckSpeed()
                 {
                     if (MaxSpeed > 110)
                     {
                         Console.WriteLine("Sürət öldürür");
                     }
                     else
                     {
                         Console.WriteLine("Belə davam edin");
                     }
                 }
             }

         }*/


        class User
        {
            public string Name { get; set; }
            public string Password { get; set; }

            public User(string name, string password)
            {
                Name = name;
                Password = password;
            }

            public bool IsPasswordValid()
            {
                if (Password.Length < 6 || !Password.Any(char.IsDigit) || Password.Contains(Name))
                {
                    return false;
                }
                return true;
            }
        }








