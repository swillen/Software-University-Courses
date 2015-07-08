package _5_CSharpExams;

import java.util.Locale;
import java.util.Scanner;

/**
 * Created by veronica on 25.01.15.
 */
public class _01_CheatSheet {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);
        short row = sc.nextShort();
        sc.nextLine();
        short col= sc.nextShort();
        sc.nextLine();
        long vertStartNumb = sc.nextLong();
        sc.nextLine();
        long horStartNumb = sc.nextLong();
        sc.nextLine();

        for (long i = vertStartNumb; i < vertStartNumb+row; i++) {
            for (long j = horStartNumb; j < horStartNumb+col; j++) {
                System.out.print(i * j + " ");
            }
            System.out.println();
        }
    }
}
