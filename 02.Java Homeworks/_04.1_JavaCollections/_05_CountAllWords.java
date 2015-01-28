package _03_JavaCollections;

import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by veronica on 24.01.15.
 */
public class _05_CountAllWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String reg = "[^a-zA-Z]+";
        String [] values = input.split(reg);
        System.out.println(values.length);
    }
}
