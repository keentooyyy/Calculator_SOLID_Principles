interface ICalculateOperation
{
    double Operate(double num1, double num2);
}

class Program
{
    public static void Main(String[] args)
    {
        ICalculateOperation addition = new Addition();
        ICalculateOperation subtraction = new Subtraction();
        ICalculateOperation multiplication = new Multiplication();
        ICalculateOperation division = new Division();

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine().Trim());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine().Trim());

        Console.WriteLine("Choose an Operation");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        Console.Write("Choose a number: ");
        int choice = Convert.ToInt32(Console.ReadLine().Trim());

        switch (choice)
        {
            case 1:
                Console.WriteLine(addition.Operate(num1, num2));
                break;
            case 2:
                Console.WriteLine(subtraction.Operate(num1, num2));
                break;
            case 3:
                Console.WriteLine(multiplication.Operate(num1, num2));
                break;
            case 4:
                Console.WriteLine(division.Operate(num1, num2));
                break;
        }
    }
}

class Calculator
{
    private ICalculateOperation _calculateOperation;

    public Calculator(ICalculateOperation calOperation)
    {
        _calculateOperation = calOperation;
    }

    public double PerformOperation(double num1, double num2)
    {
        return _calculateOperation.Operate(num1, num2);
    }
}


class Addition : ICalculateOperation
{
    public double Operate(double num1, double num2)
    {
        return num1 + num2;
    }
}

class Subtraction : ICalculateOperation
{
    public double Operate(double num1, double num2)
    {
        return num1 - num2;
    }
}

class Multiplication : ICalculateOperation
{
    public double Operate(double num1, double num2)
    {
        return num1 * num2;
    }
}

class Division : ICalculateOperation
{
    public double Operate(double num1, double num2)
    {
        return num1 / num2;
    }
}