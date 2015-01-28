package _Java_Exam_07_January;

import java.util.ArrayList;
import java.util.Scanner;

/**
* Created by veronica on 27.01.15.
*/
public class _03_FireTheArrows {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());

        String[][] matrix = new String[n][];
        String inp = "";
        for (int i = 0; i < n; i++) {
            String line = sc.nextLine();
            inp+=line;

        }
        System.out.println(inp);
        createMatrix(inp,n,matrix);
    }

    private static void createMatrix(String inp, int n, String[][] matrix) {
        for (int i = 0; i < n; i++) {
            matrix[i]= new String[4];
            for (int j = 0; j < 4; j++) {
                    matrix[i][j]= String.valueOf(inp.charAt(j));
            }
        }
    }


}
