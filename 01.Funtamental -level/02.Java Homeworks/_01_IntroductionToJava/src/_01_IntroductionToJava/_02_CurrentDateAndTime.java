package _01_IntroductionToJava;

import java.time.LocalDateTime;

public class _02_CurrentDateAndTime {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		LocalDateTime curent = LocalDateTime.now();
		System.out.printf("%1$tA %1$td.%1$tm.%1$tY",curent);
	}

}
