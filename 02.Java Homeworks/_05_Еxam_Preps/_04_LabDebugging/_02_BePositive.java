package _04_LabDebugging;

import java.util.ArrayList;
import java.util.Scanner;

/**
 * Created by veronica on 25.01.15.
 */
public class _02_BePositive {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);

        byte countSequences = scn.nextByte();
        scn.nextLine();
        for (short i = 0; i < countSequences; i++) {
            String[] input = scn.nextLine().trim().split(" ");
            ArrayList<Short> numbers = new ArrayList<>();

            for (short j = 0; j < input.length; j++) {
                if(!input[j].equals("")) {
                    short num = Short.parseShort(input[j]);
                    numbers.add(num);
                }
            }
            boolean found = false;

            for (short j = 0; j < numbers.size(); j++) {
                short currentNum = numbers.get(j);

                if (currentNum >= 0) {
                    System.out.printf("%d%s", currentNum, j == (numbers.size()-1)  ? "\n" : " ");
                    found = true;
                }else if(j==numbers.size()-1 && currentNum<0){
                    continue;

                }
                else
                 {
                    currentNum += numbers.get(j + 1);

                    if (currentNum >= 0) {
                        System.out.printf("%d%s", currentNum, j == (numbers.size()-2)  ? "\n" : " ");
                        found = true;
                    }
                    j++;
                }
            }

            if (!found) {
                System.out.println("(empty)");
            }
        }
    }
}
