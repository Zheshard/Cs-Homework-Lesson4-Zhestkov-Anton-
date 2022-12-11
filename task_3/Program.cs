// Программа, которая задаёт массив из 8 элементов и выводит их на экран.
System.Console.WriteLine(string.Join(" | ", CreateArray(10, 1000)));

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