package _03_LoopsMethodsClasses;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Locale;

public class _09_ListOfProducts {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Locale.setDefault(Locale.ROOT);
             ArrayList<Product> products = new ArrayList<Product>();
             BufferedReader reader;
             BufferedWriter writer = null;
             try {
                     reader = new BufferedReader(new FileReader("inputProducts.txt"));
                     String line = null;
                     while ((line = reader.readLine()) != null) {
                        String[] splittedLine = line.split(" ");
                        products.add(new Product(splittedLine[0], Double.parseDouble(splittedLine[1])));
                     }
                     Collections.sort(products);
                    
                     writer = new BufferedWriter(new FileWriter("outputProducts.txt"));
                     for(Product product : products){
                             writer.write(product.getName() + " " + product.getPrice() + "\r\n");
                     }
                     writer.close();
             }
             catch (Exception e) {
                     System.out.println("Error");
             }
	}

}
