package _5_CSharpExams;

import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by veronica on 26.01.15.
 */
public class _05_ByteParty {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
             int n  =Integer.parseInt(sc.nextLine());

             for (int i = 0; i < n; i++) {
                 int numb = Integer.parseInt(sc.nextLine());
                 String[] binary = String.format("%8s", Integer.toBinaryString(numb)).replace(' ', '0').split("");
                 System.out.println(Arrays.toString(binary));
                 break;
             }
          // TODOOOOOOOOOOOOOOOOOOOOO
    }
}
