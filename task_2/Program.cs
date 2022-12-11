// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
int number = inputNumber("Введите число: ");

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
