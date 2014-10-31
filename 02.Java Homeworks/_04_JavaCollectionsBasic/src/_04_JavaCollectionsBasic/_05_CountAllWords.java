package _04_JavaCollectionsBasic;

import java.util.Scanner;

public class _05_CountAllWords {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		String [] words = input.nextLine().split("[!a-zA-Z]+");//non letters become separator
		//String [] words = input.nextLine().split("\\W"); // mathes non-letters
		System.out.println(words.length);
	}

}
