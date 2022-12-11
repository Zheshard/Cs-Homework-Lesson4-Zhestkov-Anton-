// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
int number = InputNumber("Введите число: ");
System.Console.WriteLine(NumberSum(number));

int InputNumber(string invitationText)
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

int NumberSum(int num)
{
	string numString = Convert.ToString(num);
	int sum = 0;
	for (int i = 0; i < numString.Length; i++)
	{
		sum = sum + Convert.ToInt32($"{numString[i]}");
	}
	return sum;
}
