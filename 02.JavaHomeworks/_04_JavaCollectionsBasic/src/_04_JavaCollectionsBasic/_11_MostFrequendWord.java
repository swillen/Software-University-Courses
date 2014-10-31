package _04_JavaCollectionsBasic;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;


public class _11_MostFrequendWord {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		String[] words = sc.nextLine().toLowerCase().split("[\\W]+");
		int maxCounter = 1;

		Map<String, Integer> wordsCount = new HashMap<String, Integer>();
		for (String string : words) {
			if (wordsCount.containsKey(string)) {
				wordsCount.put(string, wordsCount.get(string)+1);
			} else {
				wordsCount.put(string,1);
			}
		}
		
		for (Map.Entry<String, Integer> word : wordsCount.entrySet()) {
			if (word.getValue()>maxCounter) {
				maxCounter=word.getValue();
			}
		}
		
		for (Map.Entry<String, Integer> word : wordsCount.entrySet()) {
			if (word.getValue().equals(maxCounter)) {
			System.out.println(word.getKey()+"-->"+word.getValue()+" times");
			}
		}

	}
}
