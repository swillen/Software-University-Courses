package _Java_Exam_07_January;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

/**
 * Created by veronica on 26.01.15.
 */
public class _01_Pyramid {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String nAsString  = sc.nextLine();
        int n  = Integer.parseInt(nAsString.trim());

        int searched= sc.nextInt();
        sc.nextLine();
        ArrayList<Integer> result = new ArrayList<>();
        result.add(searched);
        for (int i = 0; i < n-1; i++) {
            boolean checker = false;
            String[] numbs = sc.nextLine().split("[\\s]+");
            ArrayList<Integer> arrNumbs = new ArrayList<>();
            for (String numb : numbs) {
                if(!numb.equals("")){
                    arrNumbs.add(Integer.parseInt(numb));
                }
            }
            Collections.sort(arrNumbs);
            for (int j = 0; j < arrNumbs.size(); j++) {
                if(arrNumbs.get(j)>searched){
                    searched=arrNumbs.get(j);
                    checker=true;
                    break;
                }

            }
            if(checker==false){
                searched+=1;
            }else {

                result.add(searched);
            }
        }
        System.out.println(result.toString().replace("[","").replace("]",""));
    }
}
