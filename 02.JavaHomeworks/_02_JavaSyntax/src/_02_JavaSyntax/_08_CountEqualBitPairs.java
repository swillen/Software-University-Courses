package _02_JavaSyntax;

import java.util.Scanner;

public class _08_CountEqualBitPairs {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		int number = sc.nextInt();
		int counter = 0; 
		String bits = Integer.toBinaryString(number);
		for (int i = 0; i < bits.length()-1; i++) {
			if (bits.charAt(i) == bits.charAt(i + 1)) {
				counter ++;
			}

		}
		System.out.println(counter);
	}

}
 