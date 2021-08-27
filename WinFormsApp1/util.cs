using System;

/**
 * This class contains thev backend in order for this program to work
 * It contains methods to calulate from C to F and F to C
 * 
 * 
 * 
 * 
 */

public class Class1
{


	/**
	 * This method calculates from C to  F
	 * @param C the celcius used to calculate to F
	 * @return the results 
	 * 
	 */
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
