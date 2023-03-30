/*Polymorphism

A friend of yours wants to create a special calculator.
He only wants two operations to be handled by that calculator
i.e. : addition and subtraction.
The calculator can only accept either 2 numbers or 3 numbers.

There are two functionalities for this calculator -
1. Normal -> in this role - the calculator works normally
 - where upon adding the numbers are added,
while upon subtracting the numbers are subtracted.

2. Opposite -> in this role - the calculator works opposite
to the normal role - where upon adding the numbers are subtracted,
 while upon subtracting the numbers are added.
That friend have approached you for the help, in creating
 such a calculator.*/


namespace TaskMar30
{
    class Calculator
    {
        //Constructor
        public Calculator(int mode)
        {
            //Check if mode is 1 or 2
            if (mode == 1)
            {
                //Create object of Normal class
                Normal normal = new Normal();
                Console.WriteLine("Normal Mode");
                Console.WriteLine("Enter operation \n1.Add \n2.Subtract");
                //Read user input and convert to int
                int operation = Convert.ToInt32(Console.ReadLine());
                //Check if operation is 1 or 2
                if (operation == 1)
                {
                    Console.WriteLine("Enter 2 or 3 numbers");
                    //Getting user Input in a row by giving in space and convert to list
                    List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                    //Check if list has 2 or 3 elements
                    if (numbers.Count == 2)
                    {
                        //Call Add method
                        normal.Add(numbers[0], numbers[1]);
                    }
                    else if (numbers.Count == 3)
                    {
                        //Call Add method with 3 parameters
                        normal.Add(numbers[0], numbers[1], numbers[2]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of arguments");
                    }

                }
                else if (operation == 2)
                {
                    Console.WriteLine("Enter 2 or 3 numbers");
                    //Getting user Input in a row by giving in space and convert to list
                    List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                    //Check if list has 2 or 3 elements
                    if (numbers.Count == 2)
                    {
                        //Call Add method
                        normal.Subtract(numbers[0], numbers[1]);
                    }
                    else if (numbers.Count == 3)
                    {
                        //Call Add method with 3 parameters
                        normal.Subtract(numbers[0], numbers[1], numbers[2]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of arguments");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation");
                }
            }
            else if (mode == 2)
            {
                //Create object of Opposite class
                Opposite opposite = new Opposite();
                Console.WriteLine("Normal Mode");
                Console.WriteLine("Enter operation \n1.Add \n2.Subtract");
                //Read user input and convert to int
                int operation = Convert.ToInt32(Console.ReadLine());
                //Check if operation is 1 or 2
                if (operation == 1)
                {
                    Console.WriteLine("Enter 2 or 3 numbers");
                    //Getting user Input in a row by giving in space and convert to list
                    List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                    //Check if list has 2 or 3 elements
                    if (numbers.Count == 2)
                    {
                        //Call Add method
                        opposite.Add(numbers[0], numbers[1]);
                    }
                    else if (numbers.Count == 3)
                    {
                        //Call Add method with 3 parameters
                        opposite.Add(numbers[0], numbers[1], numbers[2]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of arguments");
                    }

                }
                else if (operation == 2)
                {
                    Console.WriteLine("Enter 2 or 3 numbers");
                    //Getting user Input in a row by giving in space and convert to list
                    List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                    //Check if list has 2 or 3 elements
                    if (numbers.Count == 2)
                    {
                        //Call Add method
                        opposite.Subtract(numbers[0], numbers[1]);
                    }
                    else if (numbers.Count == 3)
                    {
                        //Call Add method with 3 parameters
                        opposite.Subtract(numbers[0], numbers[1], numbers[2]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of arguments");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation");
                }


            }
            else
            {
                Console.WriteLine("Invalid mode");
            }
        }
    }
    class Normal
    {
        //Add method
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition of {0} and {1} is {2}", a, b, a + b);
        }
        //Subtract method
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtraction of {0} and {1} is {2}", a, b, a - b);
        }
        //Add method with 3 parameters
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("Addition of {0}, {1} and {2} is {3}", a, b, c, a + b + c);
        }
        //Subtract method with 3 parameters
        public void Subtract(int a, int b, int c)
        {
            Console.WriteLine("Subtraction of {0}, {1} and {2} is {3}", a, b, c, a - b - c);
        }
    }
    class Opposite
    {
        //Add method
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition of {0} and {1} is {2}", a, b, a - b);
        }
        //Subtract method
        public void Subtract(int a, int b)
        {
            Console.WriteLine("Subtraction of {0} and {1} is {2}", a, b, a + b);
        }
        //Add method with 3 parameters
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("Addition of {0}, {1} and {2} is {3}", a, b, c, a - b - c);
        }
        //Subtract method with 3 parameters
        public void Subtract(int a, int b, int c)
        {
            Console.WriteLine("Subtraction of {0}, {1} and {2} is {3}", a, b, c, a + b + c);
        }
    }

    class Problem1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter calculator mode 1.Normal\n2.Opposite");
            //Read user input and convert to int
            int mode = Convert.ToInt32(Console.ReadLine());
            //Create object of Calculator class
            Calculator calc = new Calculator(mode);

        }
    }
}
