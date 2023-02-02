namespace task2;
class Program
{
	static void Main(string[] args)
	{
		int num ;

		ToConvert("salam", out num);

		Console.WriteLine(num);





	}
	static void ToConvert(string value, out int number)
	{
		try
		{
            number = Convert.ToInt32(value);
        }
		catch (Exception ex)
		{
			number = 0;
		}
		
	}
}

