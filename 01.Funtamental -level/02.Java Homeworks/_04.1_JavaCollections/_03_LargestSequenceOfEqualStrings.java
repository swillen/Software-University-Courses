package _03_JavaCollections;

import java.util.Scanner;

/**
 * Created by veronica on 23.01.15.
 */
public class _03_LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int counter= 1;
        int maxCounter=1;
        String value = "";
        String [] input = sc.nextLine().split(" ");

        for (int i = 0; i < input.length-1; i++) {
            if(input[i].equals(input[i+1])){
                counter++;
                if(counter>maxCounter){
                    maxCounter=counter;
                    value=input[i];
                }
            }else{
                counter=1;
            }
        }
        if(maxCounter==1){
            System.out.println(input[0]);
        }else {
            for (int i = 0; i <maxCounter; i++) {
                System.out.print(value+" ");
            }
        }
    }
}
