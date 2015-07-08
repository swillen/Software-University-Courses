package _03_JavaCollections;

import java.io.PrintStream;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by veronica on 24.01.15.
 */
public class _08_ExtractEmails {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        Pattern pattern = Pattern.compile("([a-zA-Z]+\\.*\\_*\\-*[a-zA-Z]*\\@[a-zA-Z]+(?:[\\.]*[\\-]*[a-zA-Z]+){1,})",Pattern.MULTILINE);
        Matcher match = pattern.matcher(input);
        while (match.find()){

            System.out.println(match.group(1));

        }

    }
}
