// Программа, которая задаёт массив из 8 элементов и выводит их на экран.
int leftRange = inputNumber("Введите значение начала диапазона: ");
int rightRange = inputNumber("Введите значение конца диапазона: ") + 1;
OutputArray(CreateArray(leftRange, rightRange));

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

int[] CreateArray(int leftRange, int rightRange)
{
	int[] randomArray = new int[8];
	Random randNumber = new Random();
	for (int i = 0; i < randomArray.Length; i++)
	{
		randomArray[i] = randNumber.Next(leftRange, rightRange);
	}
	return randomArray;
}

void OutputArray(int[] array)
{
	System.Console.WriteLine(string.Join("_", array));
}
