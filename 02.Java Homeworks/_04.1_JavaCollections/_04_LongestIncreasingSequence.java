package _03_JavaCollections;

import java.util.Scanner;

/**
 * Created by veronica on 23.01.15.
 */
public class _04_LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        int counter = 1;
        int maxCounter=1;
        int p =0;

        for (int i = 0; i < input.length-1; i++) {
            if(Integer.parseInt(input[i])<Integer.parseInt(input[i+1])){
                counter++;
                if(counter>maxCounter){
                    maxCounter=counter;
                    p=i;
                    System.out.print(input[i]+" ");

                }else{
                    System.out.print(input[i] + " ");
                }
            }else{
                counter=1;
                System.out.println(input[i]+" ");
            }
        }
        System.out.println(input[input.length-1]);
        int currPosition = (p-maxCounter)+2;
        if(maxCounter==1){
            System.out.println("Longest sequence:"+input[0]);
        }else {
            System.out.print("Longest sequence:");
            for (int i = currPosition; i < currPosition + maxCounter; i++) {
                System.out.print(input[i] + " ");
            }
        }
    }
}
