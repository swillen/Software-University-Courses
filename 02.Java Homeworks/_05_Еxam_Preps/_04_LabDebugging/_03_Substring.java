package _04_LabDebugging;

import java.util.Scanner;

/**
 * Created by veronica on 25.01.15.
 */
public class _03_Substring {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String text = input.nextLine();
        int jump = Integer.parseInt(input.nextLine());

        char search = 'p';

        boolean hasMatch = false;

        for (int i = 0; i < text.length(); i++) {
            int endIndex =i;
            if (text.charAt(i)==search) {
                hasMatch = true;

                endIndex+=jump;

                if (endIndex >=text.length()) {
                    endIndex = text.length()-1;
                }

                String matchedString = text.substring(i, endIndex+1);
                System.out.println(matchedString);
                i = endIndex;
            }
        }

        if (!hasMatch) {
            System.out.println("no");
        }
    }
}
