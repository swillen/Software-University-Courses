package _04_JavaCollectionsBasic;

import java.util.Scanner;

public class _02_SequenceOfEqualStrings {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		String [] words = input.nextLine().split(" ");
		System.out.print(words[0]+" ");
		for (int i = 1; i < words.length; i++) {
			if (words[i].equals(words[i-1])) {
				System.out.print(" "+words[i]);
			}
			else {
				System.out.println();
				System.out.print(words[i]);
			}
		}
		
	
	}

}
