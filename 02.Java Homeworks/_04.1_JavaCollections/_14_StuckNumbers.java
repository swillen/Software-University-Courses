package _03_JavaCollections;

import java.util.Scanner;

/**
 * Created by veronica on 25.01.15.
 */
public class _14_StuckNumbers {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        sc.nextLine();
        String[] numbs = new String[n];
        for (int i = 0; i < n; i++) {
            numbs[i] = sc.next();
        }
        Boolean checker = false;
        for (int a = 0; a < numbs.length; a++) {
            for (int b = 0; b < numbs.length; b++) {
                if (a != b) {
                    for (int c = 0; c < numbs.length; c++) {
                        if (b != c) {
                            for (int d = 0; d < numbs.length; d++) {
                                if (c != d) {
                                    if ((numbs[a] + numbs[b]).equals(numbs[c]
                                            + numbs[d])
                                            && a != b
                                            && a != c
                                            && a != d
                                            && b != a
                                            && b != c
                                            && b != d
                                            && c != a
                                            && c != b
                                            && c != d
                                            && d != a && d != b && d != c) {
                                        checker = true;
                                        System.out.println(numbs[a] + "|"
                                                + numbs[b] + "==" + numbs[c]
                                                + "|" + numbs[d]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!checker) {
            System.out.println("No");
        }
    }
}
