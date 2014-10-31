package _02_JavaSyntax;

import java.util.Scanner;

public class _02_TriangleArea {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Scanner input = new Scanner(System.in);
		int aX = input.nextInt();
		int aY = input.nextInt();

		int bX = input.nextInt();
		int bY = input.nextInt();

		int cX = input.nextInt();
		int cY = input.nextInt();
		
		double area =(double)(aX*(bY-cY)+bX*(cY-aY)+cX*(aY-bY))/2; 
		System.out.println(Math.abs((int)area));
	}

}
