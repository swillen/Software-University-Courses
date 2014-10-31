package _04_JavaCollectionsBasic;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Scanner;

// CTRL + D --> delete the all line
public class _04_LongestEncreasingSequence {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		String[] inp = input.nextLine().split(" ");
		int[] numbers = new int[inp.length];
		int currenLenght = 1;
		int maxLenght = 0;
		int temp = 0;
		int lastArrayIndex = 0;
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(inp[i]);
		}
		for (int i = 0; i < numbers.length - 1; i++) {
			if (numbers[i] < numbers[i + 1]) {
				System.out.print(numbers[i] + " ");
				currenLenght++;
				if (currenLenght > temp) {
					maxLenght = currenLenght;
					lastArrayIndex = i; //  numbers of the last index of increasing sequence +1
				}
				temp = currenLenght;

			} else {
				System.out.println(numbers[i]);
				currenLenght = 1;

			}
		}
		System.out.println(numbers[inp.length - 1]);
		System.out.print("Longest: ");
		if (maxLenght > 1) { // if the numbers of increasing elements is more than one 
			for (int i = 1; i <= maxLenght; i++) {
				System.out.print(numbers[lastArrayIndex + 1 - maxLenght + i]+ " ");//prints the longest increasing sequences 
			}
		} else { // else print the longest equal element is the first one 
			System.out.print(numbers[0]);
		}

	}

}
