
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

///<summary>
/// Draft
/// </summary>
namespace Draft
{
    [Author("Tsvetelin Marinov")]
    /// <summary>
    ///  Defines methods and properties to descibe a human
    /// </summary>
    public class Human
    {
        //Holds the name
        private string? name;

        //Holds the age
        private int age;

        //Holds the height is cm
        private int heigth;

        //Hold the weigth in format kg.g
        private int weigth;

        //Holds the nationality of the human
        private string? nationality;

        //Holds the proffesion of the human
        private string? proffesion;


        /// <summary>
        ///  Get or set the name of the human
        /// </summary>
        public string? Name
        {
            get => name;           
            set
            {
                ArgumentNullException.ThrowIfNull(value);

                if (!value.GetType().Equals(typeof(string)))
                {
                    throw new Exception("Invalid type of the name!");
                }

                name = value;
            }
        }

        /// <summary>
        ///  Get or set the age of the human
        /// </summary>
        public int Age
        {
            get => age;
            set
            {
                ArgumentNullException.ThrowIfNull(value);

                if (value.GetType().Equals(typeof(int)))
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Invalid data type or value of the age!");
                }
            }
        }

        /// <summary>
        ///  Get or set the heigth of the human
        /// </summary>
        public int Heigth
        {
            get => heigth;
            set
            {
                ArgumentNullException.ThrowIfNull(value);

                if (value.GetType().Equals(typeof(int)))
                {
                    heigth = value;
                }
                else
                {
                    throw new Exception("Invalid value for age");
                }
            }
        }

        /// <summary>
        ///  Get or set the weigth of the human
        /// </summary>
        public int Weigth
        {
            get => weigth;
            set
            {
                ArgumentNullException.ThrowIfNull(value);

                if (value.GetType().Equals(typeof(int)))
                {
                    weigth = value;
                }
                else
                {
                    throw new Exception("Invalid value for age");
                }
            }
        }

        /// <summary>
        ///  Get or set the nationality of the human
        /// </summary>
        public string? Nationality
        {
            get => nationality;
            set
            {
                ArgumentNullException.ThrowIfNull(value);

                if (value.GetType().Equals(typeof(string)))
                {
                    nationality = value;
                }
                else
                {
                    throw new Exception("Invalid value for age");
                }
            }
        }

        /// <summary>
        ///  Get or set the proffesion assosiated with that human
        /// </summary>
        public string? Proffesion
        {
            get => proffesion;
            set
            {
                ArgumentNullException.ThrowIfNull(value);

                if (value.GetType().Equals(typeof(string)))
                {
                    proffesion = value;
                }
                else
                {
                    throw new Exception("Invalid value for age");
                }
            }
        }


        /// <summary>
        ///  Create instace of the Human class with name
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            Name = name;
        }

        /// <summary>
        ///  Create instance of the Human class with name and age
        /// </summary>
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /// <summary>
        ///  Create instance of the Human class with name, age and heigth
        /// </summary>
        public Human(string name, int age, int heigth)
        {
            Name = name;
            Age = age;
            Heigth = heigth;
        }

        /// <summary>
        ///  Create instance of the Human class with name, age, heigth and weigth
        /// </summary>
        public Human(string name, int age, int heigth, int weigth)
        {
            Name = name;
            Age = age;
            Heigth = heigth;
            Weigth = weigth;
        }

        /// <summary>
        ///  Create instance of the Human class with name, age, heigth, weigth and nationality
        /// </summary>
        public Human(string name, int age, int heigth, int weigth, string nationality)
        {
            Name = name;
            Age = age;
            Heigth = heigth;
            Weigth = weigth;
            Nationality = nationality;
        }

        /// <summary>
        ///  Create instance of the Human class with name, age, heigth, weigth, nationality and proffesion
        /// </summary>
        public Human(string name, int age, int heigth, int weigth, string nationality, string proffesion)
        {
            Name = name;
            Age = age;
            Heigth = heigth;
            Weigth = weigth;
            Nationality = nationality;
            Proffesion = proffesion;
        }


        /// <summary>
        ///  Prints the <param name="message"> on the console
        /// </summary>
        /// <param name="message">The message to be printed</param>
        public void Speak(string message)
        {
            ArgumentNullException.ThrowIfNullOrWhiteSpace(message);
            Console.WriteLine($"\n\n{message}\n\n");
        }

        /// <summary>
        ///  Prints all the information about that human on the console
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine(
                $"\nFull name : {Name}\n" +
                $"Age : {Age}\n" +
                $"Heigth in cantimeters : {Heigth}\n" +
                $"Weigth in kilograms : {Weigth}\n" +
                $"Nationality : {Nationality}\n" +
                $"Proffesion : {Proffesion}\n\n"
            );
        }

        /// <summary>
        ///  Prints the eaten product in the console
        /// </summary>
        /// <param name="product">The product wich will be eaten</param>
        public void Eat(string product)
        {
            Console.WriteLine($"The {product} are eaten!");
        }

        /// <summary>
        ///  Fall asleep for specified hours 
        /// </summary>
        /// <param name="hours">The hours of sleeping</param>
        public void Sleep(int hours)
        {
            Console.WriteLine($"Falling asleep for {hours} hours!");
        }
    }
}
