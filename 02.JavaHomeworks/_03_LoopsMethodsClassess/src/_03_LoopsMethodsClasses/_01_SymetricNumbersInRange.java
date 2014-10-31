package _03_LoopsMethodsClasses;

import java.util.Scanner;

public class _01_SymetricNumbersInRange {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		int start = input.nextInt();
		int endN = input.nextInt();

		for (int i = start; i <=endN; i++) {

			if (Integer.toString(i)
					.equals(new StringBuilder(Integer.toString(i)).reverse()
							.toString())) {
				System.out.print(i+" ");
			} else {
				continue;
			}
		}
	}
}

