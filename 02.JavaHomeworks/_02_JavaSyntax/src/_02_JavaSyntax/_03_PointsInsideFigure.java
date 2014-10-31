package _02_JavaSyntax;

import java.util.Locale;
import java.util.Scanner;

public class _03_PointsInsideFigure {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Locale.setDefault(Locale.ROOT);
		Scanner input = new Scanner(System.in);
		double x = input.nextDouble();
		double y = input.nextDouble();
		
		//outside
		if (x<12.5 || x>22.5 || y<6 || y>13.5) {
			System.out.println("Outside");
		}
		//inside
		else {
			if (x>17.5 && x<20 && y>8.5 && y<13.5) {
				System.out.println("Outside");
			}
			System.out.println("Inside");
		}
	}

}
