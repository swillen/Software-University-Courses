package _02_JavaSyntax;

import java.util.Scanner;

public class _05_DecimalToHexadecimal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		int decimal = input.nextInt();
		System.out.println(Integer.toHexString(decimal).toUpperCase());
	}

}
