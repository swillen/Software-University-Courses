package _03_JavaCollections;

import java.util.Scanner;

/**
 * Created by veronica on 25.01.15.
 */
public class _15_SumCards {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String line = sc.nextLine().replace("J", "12").replace("Q", "13")
                .replace("K", "14").replace("A", "15");
        line = line.replaceAll("[a-zA-Z]+", "");
        String[] lines = line.split(" ");

        int[] intvalues = new int[lines.length];
        for (int i = 0; i < intvalues.length; i++) {
            intvalues[i] = Integer.parseInt(lines[i]);
        }
        int counter = 0;
        int sum = 0;
        Boolean checker = false;
        for (int i = 0; i < intvalues.length; i++) {
            counter++;
            if(counter>=intvalues.length){
                sum+=intvalues[intvalues.length-1];
                break;
            }
            while (intvalues[i]==intvalues[counter] && i<counter ) {

                sum+=intvalues[i]*2;
                counter++;
                checker=true;
                if(counter>=intvalues.length){
                    break;
                }
            }
            if(checker==true){
                sum+=intvalues[i]*2;
                checker=false;
            }else{
                sum+=intvalues[i];
            }
            i=counter-1;
        }
        System.out.println(sum);
    }
}
