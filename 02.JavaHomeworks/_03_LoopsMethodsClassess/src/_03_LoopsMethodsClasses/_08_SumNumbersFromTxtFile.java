package _03_LoopsMethodsClasses;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class _08_SumNumbersFromTxtFile {

	public static void main(String[] args) throws NumberFormatException, IOException {
		// TODO Auto-generated method stub
		 try {
             BufferedReader in = new BufferedReader(new FileReader("Input.txt"));
             String line;
             int sum = 0;
             while ((line = in.readLine()) != null) {
                     sum += Integer.parseInt(line);
             }
             System.out.println(sum);
             in.close();
     } catch (java.io.FileNotFoundException nfe) {
             System.out.println("Error");
     }
	}

}
