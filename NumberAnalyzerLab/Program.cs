Console.WriteLine("Hello. Welcome to the Number Analyzer. What is your name?");
string name = Console.ReadLine();

{
    string userInput;
    bool continueLoop;
    do
    {
        Console.WriteLine(name + ", please enter a number between 1 and 100");
        string userNumber = Console.ReadLine();
        int userNumberInteger = int.Parse(userNumber);
        {
            if (userNumberInteger <= 0)
            {
                Console.WriteLine("This number is outside of the requested range. Please try again.");
            }
            else if (userNumberInteger % 2 == 0 && userNumberInteger > 1 && userNumberInteger < 25)
            {
                Console.WriteLine(userNumberInteger + " is even and less than 25");
            }
            else if (userNumberInteger % 2 == 0 && userNumberInteger > 25 && userNumberInteger < 61)
            {
                Console.WriteLine(userNumberInteger + " is even and between 26 and 60 inclusive");
            }
            else if (userNumberInteger % 2 == 0 && userNumberInteger > 60)
            {
                Console.WriteLine(userNumberInteger + " is even and greater than 60");
            }
            else if (userNumberInteger % 2 != 0 && userNumberInteger > 60)
            {
                Console.WriteLine(userNumberInteger + " is odd and greater than 60");
            }
            else if (userNumberInteger % 2 != 0 && userNumberInteger < 60)
            {
                Console.WriteLine(userNumberInteger + " is odd and less than 60");
            }
        }
        Console.WriteLine(name + ", do you want to enter a different number? (y/n)");
        userInput = Console.ReadLine();
        continueLoop = userInput.Equals("y");
    } while (continueLoop);
}

// How can if statements be used to cover multiple situations? Can you show an example.

// If statements can be used to cover multiple situations/conditions by programming the compiler to execute (or not execute) specific blocks of code based off a condition. 

// An example of this would be using if-else statements to evaluate what letter grade a student receives based off their percentage:

//if (grade > 100)
//    Console.WriteLine("Invalid percentage");
//else if (grade >= 90)
//    Console.WriteLine("You got an A");
//else if (grade >= 80)
//    Console.WriteLine("You got a B");
//else if (grade >= 70)
//    Console.WriteLine("You got a C");
//else if (grade >= 60)
//    Console.WriteLine("You got a D");
//else
//    Console.WriteLine("You failed the exam. Please contact the teacher for a potential makeup exam");
