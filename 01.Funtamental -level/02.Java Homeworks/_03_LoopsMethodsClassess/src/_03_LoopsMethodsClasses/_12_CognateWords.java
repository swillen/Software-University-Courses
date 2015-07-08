package _02_LoopsMethodClasses;

import java.util.Arrays;
import java.util.HashSet;
import java.util.Scanner;

/**
 * Created by veronica on 23.01.15.
 */
public class _12_CognateWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        HashSet<String> toPrint = new HashSet<String>();
        String reg = "[^a-zA-Z]+";
        String [] result = input.split(reg);
        for (int i = 0; i < result.length; i++) {
            for (int j = 0; j < result.length; j++) {
                for (int k = 0; k < result.length; k++) {
                    if((result[i].trim()+""+result[j].trim()).equals(result[k].trim())){
                        toPrint.add(result[i].trim()+"|"+result[j].trim()+"="+result[k].trim());
                    }
                }
            }
        }
        if(toPrint.isEmpty()){
            System.out.println("No");
        }else {
            for (String s : toPrint) {
                System.out.println(s);
            }
        }
    }
}
