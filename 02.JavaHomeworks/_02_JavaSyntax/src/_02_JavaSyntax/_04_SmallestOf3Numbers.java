package _02_JavaSyntax;

import java.util.Arrays;
import java.util.Locale;
import java.util.Scanner;

public class _04_SmallestOf3Numbers {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Locale.setDefault(Locale.ROOT);
		Scanner input  = new Scanner(System.in);
		double a = input.nextDouble();
		double b = input.nextDouble();
		double c = input.nextDouble();
		double [] arrNumbers = {a,b,c};
		Arrays.sort(arrNumbers);
		System.out.println(arrNumbers[0]);
//		double minNumber = Math.min(a, Math.min(b, c));
//		System.out.println((int)minNumber);
		
		
	}

}
