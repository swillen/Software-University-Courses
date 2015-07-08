package _02_LoopsMethodClasses;

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

/**
 * Created by veronica on 23.01.15.
 */
public class _06_RandomHansOfCards {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        ArrayList<String> cards = new ArrayList<String>();
        for (int i = 2; i <=14; i++) {
            for (int j = 16; j < 20; j++) {
                String card = ""+i+j;
                card=card.replace("11","J").replace("12","Q").replace("13","K").replace("14","A");
                card=card.replace("16","♠").replace("17","♥").replace("18","♦").replace("19","♣");
                cards.add(card);
            }
        }
        Random rnd = new Random();
        for (int i = 0; i <n; i++) {
            for (int j = 0; j < 5; j++) {
                String rand = cards.get(rnd.nextInt(cards.size()));
                System.out.print(rand+" ");
            }
            System.out.println();
        }
    }
}
