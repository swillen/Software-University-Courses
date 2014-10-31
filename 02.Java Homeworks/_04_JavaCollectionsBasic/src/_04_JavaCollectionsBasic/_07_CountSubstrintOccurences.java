package _04_JavaCollectionsBasic;

import java.util.ArrayList;
import java.util.Scanner;

public class _07_CountSubstrintOccurences {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String word = input.nextLine().toLowerCase();
		String compare = input.nextLine().toLowerCase();
		//StringBuilder sb = new StringBuilder();
		int counter = 0;
		for (int i = 0; i <=word.length()-compare.length(); i++) {
			if (word.substring(i, i+compare.length()).equals(compare)) {
				counter++;
			}
		}
		System.out.println(counter);
		
	}

}
