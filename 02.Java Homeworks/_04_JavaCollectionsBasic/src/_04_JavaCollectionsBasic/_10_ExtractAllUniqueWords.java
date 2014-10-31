package _04_JavaCollectionsBasic;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class _10_ExtractAllUniqueWords {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		@SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);
		String [] words = sc.nextLine().toLowerCase().split("[\\W]");
		Set<String> unique = new TreeSet<>();
		for (int i = 0; i < words.length; i++) {
			unique.add(words[i]);
		}
		for (String string : unique) {
			System.out.print(string+" ");
		}
	}

}
