using System.Numerics;
using MyProgram;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("I like pizza !");
        //Console.WriteLine("Here I am !");
        //Console.Write("Haluklkl");


        //--------------------------------------------

        //  Variable in C#
        //int x; //declaration
        //x = 123; //ininialization

        //int y = 321; //declaration + initialization
        //int z = x + y;

        //Console.WriteLine(x);
        //Console.WriteLine(y);

        //Console.ReadKey();

        //int age = 21;
        //double height = 300.5;
        //bool alive = true;
        //char symbol = '@';
        //String name = "Bro";

        //Console.WriteLine("Your age is " + age);
        //Console.WriteLine("Your height is " + height + "cm");
        //Console.WriteLine("Are you alive? " + alive);
        //Console.WriteLine("Your symbol is" + symbol);

        //String username = symbol + name;
        //Console.WriteLine("Your username is: " + username);

        //-----------------------------------------

        // Constants = immutable valueswhich are known at compile time
        //             and do not change for the life of the program

        //const double pi = 3.14159;

        //Console.WriteLine(pi);

        //------------------------------------------

        // type casting = Converting a value to a different data type
        //                Useful when we accept user input(string)
        //                Different data types can do different things

        //double a = 3.14;
        //int b = Convert.ToInt32(a);

        //Console.WriteLine(b);
        //Console.WriteLine(a.GetType()); //if want to get the type

        //------------------------------------------

        // Get user input from prompt

        //Console.WriteLine("What is your name ?");
        //String name = Console.ReadLine();

        //Console.WriteLine("What's your age?");
        //int age = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Hello " + name);
        //Console.WriteLine("You are " + age + "years old");
        //-------------------------------------------
        // Math function
        //double x = 3.99;
        //double y = 5;

        //double a = Math.Pow(x, 2);
        //double b = Math.Sqrt(x);
        //double c = Math.Abs(x);
        //double d = Math.Round(x);
        //double e = Math.Ceiling(x);
        //double f = Math.Floor(x);
        //double g = Math.Max(x, y);
        //double h = Math.Min(x, y);

        //Console.WriteLine(h);
        //-------------------------------------------
        //String method
        //String fullName = "Bro Code";
        //String phoneNumber = "123-456-7890";

        //fullName = fullName.ToUpper();
        //fullName = fullName.ToLower();
        //Console.WriteLine(fullName);

        //phoneNumber = phoneNumber.Replace("-", "");
        //Console.WriteLine(phoneNumber);

        //String userName = fullName.Insert(0, "Mr.");
        //Console.WriteLine(userName); ;

        //-------------------------------------------
        // if else statement on C#

        //Console.WriteLine("Please enter your age: ");
        //int age = Convert.ToInt32(Console.ReadLine());

        //if(age >= 18)
        //{
        //    Console.WriteLine("You are now signed up!");
        //} else
        //{
        //    Console.WriteLine("You must be 18+ to sign up!");
        //}


        //-------------------------------------------
        // switch = an efficient alternative to many else if statements
        //Console.WriteLine("What day is it today?");
        //String day = Console.ReadLine();

        //switch (day)
        //{
        //    case "Monday":
        //        Console.WriteLine("It's Monday!");
        //        break;
        //    case "Tuesday":
        //        Console.WriteLine("It's Tuesday!");
        //        break;
        //    case "Wednesday":
        //        Console.WriteLine("It's Wednesday!");
        //        break;
        //    case "Thursday":
        //        Console.WriteLine("It's Thursday!");
        //        break;
        //    case "Friday":
        //        Console.WriteLine("It's Friday!");
        //        break;
        //    case "Saturday":
        //        Console.WriteLine("It's Saturday!");
        //        break;
        //    case "Sunday":
        //        Console.WriteLine("It's Sunday!");
        //        break;
        //    default:
        //        Console.WriteLine("This is not a day !");
        //        break;
        //}


        //-------------------------------------------
        // logical operators = Can be used to check if more than 1 condition
        // && (AND) || (OR)
        //Console.WriteLine("What's the temperature outside: (C)");
        //double temp = Convert.ToDouble(Console.ReadLine());

        //if(temp >= 10 && temp <= 25)
        //{
        //    Console.WriteLine("It's warm outside");
        //} else if(temp <= -50 || temp >= 50)
        //{
        //    Console.WriteLine("DO NOT GO OUTSIDE!");
        //}

        //-------------------------------------------
        //while loop = repeats some code while some condition remains true
        //Console.Write("Enter your name: ");
        //String name = Console.ReadLine();

        //while(name == "")
        //{
        //    Console.Write("Enter your name: ");
        //    name = Console.ReadLine();
        //}

        //Console.WriteLine("Hello " + name);

        //-------------------------------------------
        // for loop = repeats some code a FINITE amount of times
        //for(int i =0; i < 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //-------------------------------------------
        // Create Rock, Paper, Scissor game
        //Random random = new Random();
        //bool playAgain = true;
        //String player;
        //String computer;

        //while (playAgain)
        //{
        //    player = "";
        //    computer = "";

        //    while (player != "ROCK" && player != "PAPER"
        //        && player != "SCISSORS") {
        //        Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
        //        player = Console.ReadLine().ToUpper();
        //    }

        //    switch(random.Next(1,4))
        //    {
        //        case 1:
        //            computer = "ROCK";
        //            break;
        //        case 2:
        //            computer = "PAPER";
        //            break;
        //        case 3:
        //            computer = "SCISSORS";
        //            break;
        //    }

        //    Console.WriteLine("Player : "+ player);
        //    Console.WriteLine("Computer: "+ computer);
        //}

        //--------------------------------------------
        // array = a variable that can store multiple values. fixed size
        //String[] cars = { "BMW", "Mustang", "Corvette" };
        //Console.WriteLine(cars[0]);
        //String[] cars = new string[3];
        //cars[0] = "Tesla";
        //cars[1] = "Mustang";
        //cars[2] = "Corvette";

        //for(int i = 0; i <= cars.Length; i++)
        //{
        //    Console.WriteLine(cars[i]);
        //}

        //foreach (String car in cars)
        //{
        //    Console.WriteLine(car);
        //}

        //--------------------------------------------
        // method = performs a section of code, whenever it's called "invoked".
        //          benefit = Let's us reuse code w/o writing it multiple times
        //String name = "Ali";
        //singHappyBirthday(name);
        ////singHappyBirthday();
        //--------------------------------------------
        //return = returns data back to the place where a method is invoked

        //double x = 2.2;
        //double y = 3;

        //Console.WriteLine(Multiply(x,y));

        //--------------------------------------------
        // exception = errors that occur during execution

        // try = try some code that is considered "dangerous"
        // catch = catches and handles exceptions when they occur
        // finally = always executes regardless if exception is caught or not
        //int x;
        //int y;
        //double result;

        //try
        //{
        //    Console.Write("Enter number 1: ");
        //    x = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Enter number 2: ");
        //    y = Convert.ToInt32(Console.ReadLine());

        //    result = x / y;

        //    Console.WriteLine("result: " + result);
        //}
        //catch (FormatException e)
        //{
        //    Console.WriteLine("Enter ONLY numbers");
        //}
        //catch(DivideByZeroException e)
        //{
        //    Console.WriteLine("You cant divide by zero");
        //}
        //catch(Exception e)
        //{
        //    Console.WriteLine("There is something WRONG !");
        //}


        //--------------------------------------------
        // string interpolation = allows us to insert variables into a string literal
        //                        precede a string literal with $
        //                        {} are placeholders
        //String firstName = "Bro";
        //String lastname = "Code";
        //int age = 21;

        //Console.WriteLine($"Hello {firstName} {lastname}.");
        //Console.WriteLine($"You are {age} years old");

        //--------------------------------------------
        //class = A bundle of related code.
        //        Can be used as a blueprint to create objects (OOP)
        //Messages.Hello();
        //Messages.Waiting();

        //--------------------------------------------
        // object = An instance of a class
        //          A class can be used as a blueprint to create objects (OOP)
        //          objects can have fields & methods (characteristics & actions)

        //Human human1 = new Human();
        //Human human2 = new Human();

        //human2.name = "Morty";
        //human2.age = 62;

        //human1.name = "Rick";
        //human1.age = 65;

        //human1.Eat();
        //human1.Sleep();

        //---------------------------------------------
        // constructor = A special method in class
        //               Same name as the class name
        //               Can be used to assign arguments to fields when creating an object

        //Human human1 = new Human("Ricky", 65);

        //human1.Eat();
        //human1.Sleep();
        //---------------------------------------------
        // static = modifier to declare a static member, which belongs to the class itself
        //         rather than to any specific object

        //---------------------------------------------
        //inheritance = 1 or more child classes receiving fields, methods, etc from a common parent
        //Vehicle vehicle = new Vehicle();
        //Car car = new Car();

        //Console.WriteLine(car.speed);
        //Console.WriteLine(car.wheels);
        //car.go();
        //---------------------------------------------
        // abstract classes = modifier that indicates missing components or incomplete implementation

        //---------------------------------------------
        //method overriding = provides a new version of a method inherited from a parent class
        //                    inherited method must be: abstract, virtual, or already overriden
        //                    Used with ToString(), polymorphism

        //Dog dog = new Dog();

        //dog.Speak();


        //---------------------------------------------
        // interface = defines a "contraact" that all the classes inheriting from should follow

        //  An interface declares "what a class should have"
        //  An inheriting class defines "how it should do it"
        //  Benefit = security + multiple inheritance + "plug-and-play"

        //Rabbit rabbit = new Rabbit();
        //Hawk hawk = new Hawk();
        //Fish fish = new Fish();

        //fish.Flee();
        //fish.Hunt();

        //hawk.Hunt();
        //rabbit.Flee();

        //---------------------------------------------
        // List = data structure that represents a list of objects that can be accessed by index.
        //        Similar to array, but can dynamically increase/decrease in size
        //        using System.Collections.Generic

        //List<String> food = new List<String>();

        ////Adding up the properties
        //food.Add("pizza");
        //food.Add("hamburger");
        //food.Add("hotdog");

        //food.Remove("hotdog");
        //food.Insert(0, "Sushi");
        //Console.WriteLine(food.Contains("pizza");

        //foreach (String item in food)
        //{
        //    Console.WriteLine(item);
        //}

        //---------------------------------------------
        //List<Player> players = new List<Player>();

        //Player player1 = new Player("Chad");
        //Player player2 = new Player("Steve");
        //Player player3 = new Player("Karen");

        //players.Add(new Player("Chad"));
        //players.Add(new Player("Steve"));
        //players.Add(new Player("Karen"));

        //foreach(Player player in players)
        //{
        //    Console.WriteLine(player.username);
        //}

        //---------------------------------------------
        // getters & setters = add security to fields by encapsulation
        //                     They're accessors found within properties

        //properties = combine aspects of both fields and methods (share name with a field)
        //get accessor = used to return the property value
        //set accessor = used to assign a new value
        //value keyword = defines the value being assigned by the set (parameter)

        //Tesla car = new Tesla(400);
        //car.Speed = 200;

        //Console.WriteLine(car.Speed);

        //---------------------------------------------
        //Auto-implemented properties = shortcut when no additional logic is required in the property
        //                              you do not have to define a field for a property,
        //                              you only have to write get; and/or set; inside the property

        //Tesla tesla = new Tesla("Porshe");

        //Console.WriteLine(tesla.Model);

        //---------------------------------------------
        // enums = special "class" that contains a set of named integer constants.
        //         Use enums when you have values that you know will not change,
        //         To get the integer value from an item, you must explicitly convert to an int

        //Console.WriteLine(Planets.Pluto + " is a planet");
        //Console.WriteLine(Planets.Mercury + "is planet #" + (int)Planets.Mercury);

        //---------------------------------------------
        // thread = an execution path of a program
        //          We can use multiple threads to perform,
        //          different tasks of our program at the same time.
        //          Current thread running is "main" thread
        //          using System.Threading;

        //Thread mainThread = Thread.CurrentThread;
        //mainThread.Name = "Main Thread";


        //Declare this to run both thread at the same time
        //Thread thread1 = new Thread(CountDown);
        //Thread thread2 = new Thread(CountUp);

        //If the method requires parse in variable
        //Thread thread3 = new Thread(() => CountDown("Timer @1"));

        //thread1.Start();
        //thread2.Start();

        ////CountDown();
        ////CountUp();

        //Console.WriteLine(mainThread.Name+" is complete!");


        //----------------------------------------------
    }

    public static void CountDown()
    {
        for(int i=10; i >=0; i--)
        {
            Console.WriteLine("Timer #1: "+i+"seconds");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Time #1 is completed.");
    }

    public static void CountUp( )
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Timer #2: " + i + "seconds");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Time #2 is completed.");
    }

    //Assign the number value
    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }

    //It is auto assign the number value
    //enum Planets
    //{
    //    Mercury,
    //    Venus,
    //    Earth,
    //    Mars,
    //    Jupiter,
    //    Saturn,
    //    Uranus,
    //    Neptune,
    //    Pluto
    //}

    class Tesla
    {
        public String Model { get; set; }

        public Tesla(string model)
        {
            this.Model = model;
        }
    }

    //class Tesla
    //{
    //    public int speed;

    //    public Tesla(int speed)
    //    {
    //        this.speed = speed;
    //    }

    //    public int Speed
    //    {
    //        get { return speed; }
    //        set { this.speed = value;}
    //    }
    //}

    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }
    }



    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("Hawk is searching for foods !");
        }
    }

    class Fish : IPredator, IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish");
        }
    }

    static double Multiply(double x, double y)
    {
        double z = x * y;
        return z;
    }

    static void singHappyBirthday(String name)
    {
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday to you!");
        Console.WriteLine("Happy birthday to YOU! " + name);
        Console.WriteLine();
    }

    //For now in one file create class
    class Human
    {
        //this is fields
        public String name; 
        public int age;

        //This is a constructor
        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //this is method
        public void Eat() 
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is Sleeping");
        }
    }

    //Create class with inheritance
    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }

    //create animal class
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *brr*");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *brr*");
        }
    }

}