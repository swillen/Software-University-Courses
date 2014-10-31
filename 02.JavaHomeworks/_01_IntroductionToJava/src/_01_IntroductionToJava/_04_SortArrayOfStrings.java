package _01_IntroductionToJava;

import java.util.Arrays;
import java.util.Scanner;

public class _04_SortArrayOfStrings {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String [] towns =  new String[n];
		for (int i = 0; i < n; i++) {
			towns[i]=input.next();
		}
		
		Arrays.sort(towns);
		for (String city : towns) {
			System.out.println(city);
		}
	}		
}
