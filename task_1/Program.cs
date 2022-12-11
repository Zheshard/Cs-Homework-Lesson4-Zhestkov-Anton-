// Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (реализована с использованием цикла)
int numberA = inputNumber("Введите число А: ");
int numberB = inputNumber("Введите число B: ");
System.Console.WriteLine(Pow(numberA, numberB));

int Pow(int number, int degreeOf)
{
	int resultPow = 1;
	for (int i = 1; i <= degreeOf; i++)
	{
		resultPow = resultPow * number;
	}
	return resultPow;
}

int inputNumber(string invitationText)
{
	int number;
	while (true)
	{
		Console.Write(invitationText);
		string numString = Console.ReadLine();
		if (int.TryParse(numString, out number))
		{
			break;
		}
		Console.WriteLine("Введено неверное значение. Введите число: ");
	}
	return number;
}
