package _04_JavaCollectionsBasic;

import java.text.DecimalFormat;
import java.util.LinkedHashMap;
import java.util.Locale;
import java.util.Map;
import java.util.Scanner;

public class _12_CardsFrequencies {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);
        String[] faces = sc.nextLine().split("[\\W ]+");
       //note - LinkedHashMap is used to save the order of the entered values
        Map<String, Integer> facesFreqencies = new LinkedHashMap<>();
       
       
        for (String face : faces) {
                if (facesFreqencies.containsKey(face)) {
                        facesFreqencies.put(face, facesFreqencies.get(face) + 1);
                }
                else
                        facesFreqencies.put(face, 1);
        }
        DecimalFormat formatter = new DecimalFormat("#0.00");
        for (Map.Entry<String, Integer> face : facesFreqencies.entrySet()) {
//        	String key = face.getKey();
//        	int value = face.getValue();
            System.out.println(face.getKey() + " -> " + formatter.format((double) face.getValue() / faces.length * 100) + "%");
        	
        	//System.out.println(key + "->"+((double)value/faces.length)*100 +"%");
        }
		
	}

}
