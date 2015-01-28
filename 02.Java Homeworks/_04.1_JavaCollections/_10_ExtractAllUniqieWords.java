package _03_JavaCollections;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by veronica on 24.01.15.
 */
public class _10_ExtractAllUniqieWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String [] words = sc.nextLine().toLowerCase().split("[\\W]");
        Set<String> unique = new TreeSet<String>();
        for (int i = 0; i < words.length; i++) {
            unique.add(words[i]);

        }
        unique.remove("");
        for (String string : unique) {
            System.out.print(string+" ");
        }
    }
}
