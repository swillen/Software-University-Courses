package _03_JavaCollections;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by veronica on 24.01.15.
 */
public class _09_CombineListOfLetters {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        char [] l1= sc.nextLine().replaceAll(" ","").toCharArray();
        char [] l2= sc.nextLine().replaceAll(" ","").toCharArray();
        ArrayList<Character> chars = new ArrayList<Character>();

        for (int i = 0; i < l1.length; i++) {
            chars.add(l1[i]);
        }
        for (int i = 0; i < l2.length; i++) {
            if(!chars.contains(l2[i])){
                chars.add(l2[i]);
            }
        }
        for (Character aChar : chars) {
            System.out.print(aChar+" ");
        }
    }
}
