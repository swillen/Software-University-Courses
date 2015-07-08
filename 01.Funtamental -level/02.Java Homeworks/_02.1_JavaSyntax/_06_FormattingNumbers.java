package _02_JavaSyntax;

import java.util.Scanner;

public class _06_FormattingNumbers {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		input.nextLine();
		double b = input.nextDouble();
		double c = input.nextDouble();
		input.nextLine();
		
		String aHexString = Integer.toHexString(a).toUpperCase();
        String aBinary = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0'); 
        System.out.printf("|%-10s|%s|%10.2f|%-10.3f|",aHexString,aBinary,b,c);
       
	}

}
