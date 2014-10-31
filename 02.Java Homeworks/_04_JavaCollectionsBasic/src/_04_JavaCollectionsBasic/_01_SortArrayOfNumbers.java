package _04_JavaCollectionsBasic;

import java.util.Arrays;
import java.util.Scanner;

public class _01_SortArrayOfNumbers {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		int [] numbersArr = new int[n];
		for (int i = 0; i < n; i++) {
			numbersArr[i]=input.nextInt();
		}
		Arrays.sort(numbersArr);
		for (int i : numbersArr) {
			System.out.print(i+" ");
		}
	}

}
