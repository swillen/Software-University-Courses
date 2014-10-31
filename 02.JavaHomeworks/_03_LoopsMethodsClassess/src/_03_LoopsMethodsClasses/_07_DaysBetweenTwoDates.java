package _03_LoopsMethodsClasses;

import java.util.Scanner;
import org.joda.time.DateTime;
import org.joda.time.Days;
import org.joda.time.LocalDate;
import org.joda.time.format.DateTimeFormat;
import org.joda.time.format.DateTimeFormatter;

public class _07_DaysBetweenTwoDates {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		
		String fDate = input.next();
		String sDate = input.next();
		
		DateTimeFormatter dateFormat = DateTimeFormat.forPattern("dd-MM-YYYY");
		DateTime firstDate = dateFormat.parseDateTime(fDate);
		DateTime secondDate = dateFormat.parseDateTime(sDate);
		int days = Days.daysBetween(new LocalDate(firstDate), new LocalDate(secondDate)).getDays();
		System.out.println(days);
		
	}

}
