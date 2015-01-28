package _03_JavaCollections;

import java.util.LinkedList;
import java.util.Scanner;
import java.util.TreeSet;

/**
 * Created by veronica on 23.01.15.
 */
public class _01_SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        TreeSet<Integer> numbers = new TreeSet<Integer>();
        for (int i = 0; i < n; i++) {
            int currNumb = sc.nextInt();
            numbers.add(currNumb);
        }
        for (Integer number : numbers) {
            System.out.println(number);
        }
    }
}
