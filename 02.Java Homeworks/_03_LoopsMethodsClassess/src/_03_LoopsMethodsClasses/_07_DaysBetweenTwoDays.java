package _02_LoopsMethodClasses;

import com.sun.org.apache.xerces.internal.impl.dv.xs.DayDV;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;
import java.time.temporal.ChronoUnit;
import java.util.Date;
import java.util.Scanner;
import java.util.GregorianCalendar;


/**
 * Created by veronica on 23.01.15.
 */
public class _07_DaysBetweenTwoDays {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String firstDateInString = sc.nextLine();
        String secondDateInString = sc.nextLine();
        DateTimeFormatter dateFormat = DateTimeFormatter.ofPattern("d-MM-yyyy");

        LocalDate firstDate = LocalDate.parse(firstDateInString, dateFormat);
        LocalDate secondDate = LocalDate.parse(secondDateInString,dateFormat);
        Long minutes = ChronoUnit.DAYS.between(firstDate,secondDate);
        System.out.println(minutes);


    }
}
