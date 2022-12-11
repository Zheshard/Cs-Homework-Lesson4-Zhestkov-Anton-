// Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (реализована с использованием цикла)
int numberA = inputNumber("Введите число А: ");
int numberB = inputNumber("Введите число B: ");

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
