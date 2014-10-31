package _02_JavaSyntax;

import java.util.Scanner;

public class _07_CountOfBitsOne {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		System.out.println(Integer.bitCount(a));
		
// or
//		int counter = 0;
//		for (int i = 0; i <=32; i++) {
//			
//			int searcBit = a & 1;
//			if (searcBit==1) {
//				counter++;
//			}
//			a = a>>1;
//		}
//		System.out.println(counter);
	
	}

}

