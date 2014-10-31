package _04_JavaCollectionsBasic;


import java.util.Scanner;

public class _03_LargestSequenceOfEqualStrings {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		String[] sequence = input.nextLine().split(" ");
		int countofEqualStrings = 1;
		String value = null;
		int temp = 0;
		int max = 0;
		
		if (sequence.length==1) {
			value = sequence[0];
		}
		for (int i = 0; i < sequence.length-1; i++) {
			
			
				if (sequence[i].equals(sequence[i+1])) {
				countofEqualStrings++; // checks how many times the equal values are repeating 
				if (countofEqualStrings>temp) {
					max= countofEqualStrings; 
					value = sequence[i];    // gets the value that is most repeated
				}
				else {
					max=temp;
					continue;
				}
				
				temp=countofEqualStrings;
				}
				else {                     // if it`s not repeating it goes back to 1 
					countofEqualStrings=1;
				}
							
			}
		if (max==0) {
			value = sequence[0];
		}
		//print the value = max times
		
		for (int i = 0; i < max; i++) {
			System.out.print(value+" ");
		}
		
	}

}







