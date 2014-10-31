package _04_JavaCollectionsBasic;

import java.util.ArrayList;
import java.util.Scanner;

public class _09_CombineListsOfLetters {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		char [] firstChars = sc.nextLine().replaceAll(" ", "").toCharArray();
		char [] secondChars = sc.nextLine().replaceAll(" ", "").toCharArray();
		ArrayList<Character> l1 = new ArrayList<Character>();
		ArrayList<Character>l2= new ArrayList<Character>();
		for (Character character1 : firstChars) {
			l1.add(character1);
		}
		for (Character character2 : secondChars) {
			l2.add(character2);
		}
		ArrayList<Character> temp = new ArrayList<Character>(l1);
		for (Character character : l2) {
			if (!temp.contains(character)) {
				l1.add(character);
			}
		}
		for (Character character : l1) {
			System.out.print(character+" ");
		}
		
		
		
		
		
//		ArrayList<Character>firstList = new ArrayList<Character>();
//		firstList.add(sc.next().toString().charAt(0));
//		
		
	}

}
