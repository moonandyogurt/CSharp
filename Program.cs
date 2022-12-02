/*
int number = 5;
int numberSecond;
numberSecond = 7;
int result = number * number;
Console.WriteLine($"{number} * {number} = {result}");
Console.WriteLine(numberSecond * numberSecond);
*/


/*
int number = 6;
if (number > 10)
{
    Console.WriteLine("число больше 10");
}
else 
{
    Console.WriteLine("Число не больше 10");
}
*/

/*int number = 5;
while (number < 10)
{
    Console.WriteLine(number);
    number++;
}
*/

/*int firstNumber = 6;
int secondNumber = 36;
if (firstNumber * firstNumber == secondNumber)
{
    Console.WriteLine($"{firstNumber} * {firstNumber} = {secondNumber}");
}
else 
{
    Console.WriteLine("wroooong :P");
}
*/

/*
Console.WriteLine("Введите цифру");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Понеделник");
}
else if (number == 2)
{
    Console.WriteLine("Вторник");
}
else if (number == 3)
{
    Console.WriteLine("Sreda");
}
else if (number == 4)
{
    Console.WriteLine("Chetverg");
}
else if (number == 5)
{
    Console.WriteLine("Pyatnica");
}    
else if (number == 6)
{
    Console.WriteLine("subbota");
}
else if (number == 7)
{
    Console.WriteLine("Voskresenie");
}
else
{
    Console.WriteLine("ERROR(((");
} 
*/

/*Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
PrintPower(number);

void PrintPower(int number)
{
Console.WriteLine($"{number} * {number} = {result}");
}
*/

/*Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int count = -number;
while (count <= number)
{
    Console.Write(count + "  ");
    count++;
}
Console.WriteLine();
*/

//домашка1.задание 2
/*Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"max number is {numberA}");
}
else 
{
    Console.WriteLine($"max number is {numberB}");
}
*/

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());
int numberMax = numberA;
if (numberMax<numberB)
{
    numberMax = numberB;
    Console.WriteLine($"max number is {numberB}");
}
else if (numberMax<numberC)
{
    numberMax = numberC;
    Console.WriteLine($"max number is {numberC}");
}
else 
{
    Console.WriteLine($"max number is {numberA}");
}