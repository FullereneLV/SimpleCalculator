// See https://aka.ms/new-console-template for more information
Console.WriteLine("This is a simple calculator");
Console.WriteLine("I can do: + , -, *, /");
Console.WriteLine("Please enter first number");
var firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter second number");
var secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter operation");
var operation = Console.ReadLine();
if (secondNum == 0)
{
    Console.WriteLine("You cannot divide by zero.");
}
else
{
    Console.WriteLine($"Result is {firstNum} {operation} {secondNum} = {Operation(operation, firstNum, secondNum)}");
};

static int Operation(string option, int firstNum, int secondNum)
{
    if (option == "+") { return firstNum + secondNum; }
    else if (option == "/")
    {
        if (firstNum == 0 && secondNum != 0)
        {
            return 0;
        }
        return firstNum / secondNum; ;
    }
    else if (option == "*")
    {
        return firstNum * secondNum;
    }
    else
    {
        return firstNum - secondNum;
    }
}
