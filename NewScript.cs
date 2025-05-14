using Godot;
using System;

public partial class NewScript : Node
	static void Main()
	{
		int[,] arr = new int[11, 11];

		for (int i = 1; i < 11; i++)
		{
			for (int j = 1; j < 11; j++)
			{
				arr[i, j] = i * j;
			}
		}

		for (int i = 1; i < 11; i++)
		{
			for (int j = 1; j < 11; j++)
			{
				Console.Write($"{arr[i, j],4}");
			}
			Console.WriteLine();
		}
	}
}
}
