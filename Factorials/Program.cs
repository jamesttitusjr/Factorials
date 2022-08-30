// See https://aka.ms/new-console-template for more information
Console.WriteLine("Factorial!");

// Calculate 6 factorial (6!)
static int Factorial (6)
{
    if (number < 1)
    {
        return 0;
    }
    else if (number == 1)
    { 
        return 1;
    }
    else
    {
        return 6 * Factorial(number - 1);
    }

}

