package _5_CSharpExams;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by veronica on 25.01.15.
 */
public class _02_TextBombardment {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String text = sc.nextLine();
        int cols = Integer.parseInt(sc.nextLine());
        Double rows = Math.ceil(((float) text.length() / (float) cols));
        String[] positions = sc.nextLine().split("\\s+");
        ArrayList<Integer> bombs = new ArrayList<Integer>();

        for (String p : positions) {
            bombs.add(Integer.parseInt(p));
        }

        char[][] matrix = new char[rows.intValue()][];

        int currentSymbol = 0;
        for (int i = 0; i < matrix.length; i++) {
            matrix[i] = new char[cols];
            for (int j = 0; j < matrix[i].length; j++) {
                if (currentSymbol >= text.length()) {
                    matrix [i] [j] = ' ';
                } else {
                    matrix [i] [j] = text.charAt(currentSymbol);
                    currentSymbol++;
                }
            }
        }

        for (int bomb : bombs) {
            Boolean toSkip = false;
            Boolean visited = false;

            for (int i = 0; i < matrix.length; i++) {
                if (matrix[i][bomb] == ' ' && visited) {
                    toSkip = true;
                }
                if (!toSkip) {
                    if (matrix [i] [bomb] != ' ') {
                        matrix [i] [bomb] = ' ';
                        visited = true;
                    }
                }
            }
        }

        String buffer = "";
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                buffer += matrix [i] [j];
            }
        }

        System.out.print(buffer);
    }
}
