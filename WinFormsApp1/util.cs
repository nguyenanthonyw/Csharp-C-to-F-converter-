﻿using System;

public class Class1
{
	public static void Method2()
	{

		Console.WriteLine("test");


	}



	public static double calcF(double C)
	{
		double result;

		result = 1.8 * C + 32;
		return result;

	}

	public static double calcC(double F)
	{
		double result;

		result =  1.8 * F - 32;
		return result;

	}

}
