package _03_LoopsMethodsClasses;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Random;
import java.util.Scanner;

public class _06_RandomHandsOf5Cards {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String clubs = Character.toString('\u2663');
		String diamonds = Character.toString('\u2666');
		String hearts = Character.toString('\u2665');
		String spades = Character.toString('\u2660');

		int in = input.nextInt();

		String[] face = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J",
				"Q", "K", "A" };
		String[] suit = { spades, diamonds, hearts, clubs };
		String allCards = "";

		for (int j = 0; j < 13; j++) {
			for (int k = 0; k < 4; k++) {
				allCards += face[j] + suit[k] + " ";
			}
		}
		String[] cards = allCards.split(" ");

		for (int i = 0; i < n; i++) {
			Collections.shuffle(Arrays.asList(cards));
			System.out.printf("%s %s %s %s %s%n", cards[0], cards[1], cards[2],
					cards[3], cards[4]);
		}
	}

}
