package _04_JavaCollectionsBasic;

import java.util.Scanner;

public class _06_CountSpecifiedWord {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		String word = input.nextLine();
		String [] words = word.split("\\W");
		String searchedW = input.nextLine();
		int counter = 0;
		for (int i = 0; i < words.length; i++) {
			if (words[i].equals(searchedW)) {
				counter++;
			}
		}
		System.out.println(counter);
	}

}
