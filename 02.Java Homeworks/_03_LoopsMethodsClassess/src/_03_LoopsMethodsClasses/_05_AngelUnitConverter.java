package _03_LoopsMethodsClasses;

import java.util.Scanner;

public class _05_AngelUnitConverter {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Scanner input = new Scanner(System.in);
		int countOfLoops = input.nextInt();
		for (int i = 0; i <countOfLoops ; i++) {
			String degreeces = input.next();
			String type = input.next();
			if (type.equals("deg")) {
				
				System.out.printf("%.6f rad",convertToRadiance(Double.parseDouble(degreeces)));
			}
			else if (type.equals("rad")) {
				converttoDegreece(Double.parseDouble(degreeces));
				System.out.printf("%.6f deg",converttoDegreece(Double.parseDouble(degreeces)) );
			}
		}		
		
	}
	public static double convertToRadiance(double n){
		double result = Math.toRadians(n);
		return result;
	}
	public static double converttoDegreece (double n){
		double result = Math.toDegrees(n);
		return  result;
	}
}
