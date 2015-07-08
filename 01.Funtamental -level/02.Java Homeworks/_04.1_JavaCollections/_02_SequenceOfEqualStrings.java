package _03_JavaCollections;

import java.util.Scanner;

/**
 * Created by veronica on 23.01.15.
 */
public class _02_SequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        System.out.print(input[0]+" ");
        for (int i = 1; i < input.length; i++) {
            if(input[i].equals(input[i-1])){
                System.out.print(input[i]+" ");
            }else{
                System.out.println();
                System.out.print(input[i]+" ");
            }
        }
    }
}
