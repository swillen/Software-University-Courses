package _02_LoopsMethodClasses;

import java.util.Scanner;

/**
 * Created by veronica on 23.01.15.
 */
public class _05_AngleUnitConverter {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        sc.nextLine();
        for (int i = 0; i < n; i++) {
            String[] input = sc.nextLine().split(" ");
            if (input[1].equals("deg")) {
                degToRadiance(Integer.parseInt(input[0]));
            } else {
                radianceToDeg(Integer.parseInt(input[0]));
            }

        }
    }

    private static void radianceToDeg(int parseInt) {
        System.out.printf("%6f deg", Math.toDegrees(parseInt));

    }

    private static void degToRadiance(int parseInt) {
        System.out.printf("%6f rad", Math.toRadians(parseInt));

    }
}

