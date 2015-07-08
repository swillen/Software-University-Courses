package _03_JavaCollections;

import java.util.Arrays;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by veronica on 24.01.15.
 */
public class _06_CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] input = sc.nextLine().toLowerCase().split(" ");
        String wordSearched = sc.nextLine().toLowerCase();

        int counter =0;
        Pattern pat = Pattern.compile("\\b"+wordSearched+"\\b");
        for (String s : input) {
            Matcher match =pat.matcher(s);
            if(match.find()){
                counter++;
            }
        }
        System.out.println(counter);

    }
}
