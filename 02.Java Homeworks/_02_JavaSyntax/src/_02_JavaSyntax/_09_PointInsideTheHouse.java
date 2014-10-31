package _02_JavaSyntax;

import java.util.Locale;
import java.util.Scanner;

public class _09_PointInsideTheHouse {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Locale.setDefault(Locale.ROOT);
		Scanner sc = new Scanner(System.in);
		
		double aX = 12.5;
		double aY = 8.5;

		double bX = 17.5;
		double bY = 3.5;

		double cX = 22.5;
		double cY = 8.5;

		double pX = sc.nextDouble();
		double pY = sc.nextDouble();

		double ABCarea = Math.abs((aX * (bY - cY) + bX * (cY - aY) + cX
				* (aY - bY)));
		double ABParea = Math.abs((aX * (bY - pY) + bX * (pY - aY) + pX
				* (aY - bY)));
		double APCarea = Math.abs((aX * (pY - cY) + pX * (cY - aY) + cX
				* (aY - pY)));
		double PBCarea = Math.abs((pX * (bY - cY) + bX * (cY - pY) + cX
				* (pY - bY)));

		if (ABCarea == ABParea + APCarea + PBCarea) {
			System.out.println("Inside");
		}
		// outside
		else if (pX < 12.5 || pX > 22.5 || pY < 6 || pY > 13.5) {
			System.out.println("Outside");
		}
		// inside
		else {
			if (pX > 17.5 && pX < 20 && pY > 8.5 && pY < 13.5) {
				System.out.println("Outside");
			}
			System.out.println("Inside");
		}

	}

}