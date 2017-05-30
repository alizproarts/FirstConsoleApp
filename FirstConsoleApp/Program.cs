using System;

namespace FirstConsoleApp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World, Again!");

			Console.WriteLine(FindLongestSequenceOfZeros(0));
			Console.WriteLine(FindLongestSequenceOfZeros(1));
			Console.WriteLine(FindLongestSequenceOfZeros(5));
			Console.WriteLine(FindLongestSequenceOfZeros(10));

		}

		public static int LenthOfArray(int[] a)
		{
			return a.Length;
		}
		public static int FindLongestSequenceOfZeros(int number)
		{
			int result = 0;
			int count = 0;
			bool oneFound = false;


			while (number != 0)
			{
				int bitwiseAnd = number & 1;
				if (bitwiseAnd == 0)
				{
					count++;
				}
				else
				{
					if (!oneFound)
					{
						oneFound = true;
					}
					else
					{
						result = Math.Max(result, count);
					}
				}

				number >>= 1;
			}

			return result;
		}
	}
}
