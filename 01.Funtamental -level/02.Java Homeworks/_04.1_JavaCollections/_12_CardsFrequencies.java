package _03_JavaCollections;

import java.util.Arrays;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

/**
 * Created by veronica on 24.01.15.
 */
public class _12_CardsFrequencies {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().replaceAll("♦","").replaceAll("♠","").replaceAll("♥","").replaceAll("♣","").split("[ ]+");
        LinkedHashMap<String,Double> cardAndCount = new LinkedHashMap<String, Double>();
        int n = input.length;

        for (String s : input) {
            if(cardAndCount.containsKey(s)){

                cardAndCount.put(s,cardAndCount.get(s)+1);
            }else{
                cardAndCount.put(s, (double) 1);
            }
        }

        for (Map.Entry<String, Double> stringIntegerEntry : cardAndCount.entrySet()) {
            System.out.printf("%s -> %.2f %% \n",stringIntegerEntry.getKey(),(stringIntegerEntry.getValue()/n)*100);
        }
    }
}
