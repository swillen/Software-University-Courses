package _Java_Exam_07_January;

import java.util.Scanner;

/**
 * Created by veronica on 26.01.15.
 */
public class _02_TerroristsWin {
    public static void main(String[] args) {

        Scanner sc =new Scanner(System.in);
        
        String text = sc.nextLine();
        char[] characters = text.toCharArray();

        int startPositin=0;
        int endPosition=0;
        boolean isDropped=false;
        boolean startPFound = false;
        boolean endPFound = false;
        for (int i = 0; i < characters.length; i++) {
            if(characters[i]=='|' && isDropped==false){
                startPositin=i;
                isDropped=true;
                startPFound=true;
            }
            else if(characters[i]=='|' && isDropped==true){
                endPosition=i;
                endPFound=true;

            }if(startPFound && endPFound){
                afterTheBombing(startPositin,endPosition,characters);
                isDropped=false;
                startPFound=false;
                endPFound=false;
            }
        }
        for (int i = 0; i < characters.length; i++) {
            System.out.print(characters[i]);
        }

    }

    private static void afterTheBombing(int startPositin, int endPosition, char[] characters) {
            int bombSum=0;
            for (int i = startPositin+1; i <endPosition ; i++) {
                      bombSum+=(int)characters[i];
            }
            int bombStrenght = bombSum%10;
            startPositin=startPositin-bombStrenght;
            endPosition=endPosition+bombStrenght;
            for (int i = 0; i < characters.length; i++) {
                if(startPositin<0){
                    startPositin=0;
                }if(endPosition>=characters.length){
                    endPosition=characters.length-1;
                }
                if(i>=startPositin && i<=endPosition){
                    characters[i]='.';
                }

            }
    }
}
