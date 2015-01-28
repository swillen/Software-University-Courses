package _03_JavaCollections;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by veronica on 24.01.15.
 */
public class _11_MostFrequendWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().toLowerCase().split("[^a-zA-Z]");
        int counter = 1;

        Map<String,Integer> valAndCount = new HashMap<String, Integer>();

        for (String s : input){
            if(!s.equals("")) {
                if (valAndCount.containsKey(s)) {
                    counter++;
                    int val = valAndCount.get(s) + 1;
                    valAndCount.put(s, val);
                } else {
                    valAndCount.put(s, 1);
                }
            }
        }
        int maxVal = 1;
        for (Map.Entry<String, Integer> stringIntegerEntry : valAndCount.entrySet()) {

            int currVal = stringIntegerEntry.getValue();
            if(currVal>maxVal){
                maxVal=currVal;
            }
        }
        for (Map.Entry<String, Integer> keyAndValue : valAndCount.entrySet()) {

            if(keyAndValue.getValue()==maxVal){
                System.out.println(keyAndValue.getKey()+"->"+maxVal+" times");
            }
        }
    }
}
