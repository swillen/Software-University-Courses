package _01_IntroductionToJava;

import com.itextpdf.text.Document; // syzdavame dokument 
import com.itextpdf.text.Element;
import com.itextpdf.text.Paragraph; // dobavqme razni raboti kym dokumenta 
import com.itextpdf.text.log.SysoCounter;
import com.itextpdf.text.pdf.BaseFont;
import com.itextpdf.text.pdf.PdfWriter;
import com.itextpdf.text.Font;
import com.itextpdf.text.BaseColor;
import com.itextpdf.awt.AsianFontMapper;

import java.io.FileOutputStream; // biblioteka za zapazvane na PDF dokumenta
import java.util.Collection;



public class _05_GeneratePDFExternalLibrary {


	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		// TO -DO IS NOT FINISHED YET 
		try{

		Document document = new Document();	
		PdfWriter.getInstance(document, new FileOutputStream("Deck-of-Cards.pdf"));
		document.open();
		Paragraph cards = new Paragraph();
		String [] cardType = {"2","3","4","5","6","7","8","9","10","J","D","K","A"};
		String [] cardColor ={Character.toString('\u2663'),Character.toString('\u2666'),
							  Character.toString('\u2665'),Character.toString('\u2660')};
		for (int i = 0; i < cardType.length; i++) {
			for (int j = 0; j < cardColor.length; j++) {
				 System.out.printf("%s%s ",cardType[i],cardColor[j]);
				 
				 
				 cards.add(cardType[i]+cardColor[j]+ " "); // v paragrafa dobavqme stoinostite (vsichkite 52 karti)
			}
		}
		
		document.add(cards); // dobavq gorniq paragraf kym dokumenta
		document.close();
		
		}catch(Exception e ){
			e.printStackTrace();
		}
	}

}
