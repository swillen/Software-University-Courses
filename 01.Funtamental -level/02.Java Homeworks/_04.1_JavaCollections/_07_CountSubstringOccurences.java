package _03_JavaCollections;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by veronica on 24.01.15.
 */
public class _07_CountSubstringOccurences {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String str = sc.nextLine().toLowerCase();
        String findStr = sc.nextLine();
        int lastIndex = 0;
        int count = 0;
        while(lastIndex != -1){
            lastIndex = str.indexOf(findStr,lastIndex);

            if(lastIndex != -1){
                count ++;
                lastIndex++;
            }
        }
        System.out.println(count);

    }
}