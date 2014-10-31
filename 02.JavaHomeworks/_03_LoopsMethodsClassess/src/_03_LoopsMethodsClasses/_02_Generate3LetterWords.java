package _03_LoopsMethodsClasses;

import java.util.Scanner;

public class _02_Generate3LetterWords {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
        char[] letters = input.next().toCharArray();
        
        if (letters.length==1) {
			System.out.printf("%s",letters[0]);
		}
        if (letters.length==2) {
			for (int i = 0; i < 2; i++) {
				for (int j = 0; j<2; j++) {
					for (int j2 = 0; j2 < 2; j2++) {
						System.out.printf("%s%s%s ", letters[i],letters[j],letters[j2]);
					}
				}
			}
		}
        if (letters.length==3) {
        	for (int i = 0; i < 3; i++) {
				for (int j = 0; j<3; j++) {
					for (int j2 = 0; j2 < 3; j2++) {
						System.out.printf("%s%s%s ", letters[i],letters[j],letters[j2]);
					}
				}
			}
		}
	}

}
