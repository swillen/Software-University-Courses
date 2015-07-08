package _03_JavaCollections;

import java.util.Scanner;

/**
 * Created by veronica on 25.01.15.
 */
public class _16_SimpleExpression {
    public static void main(String[] args) {
        // TODO Auto-generated method stub
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine().trim();
        String[] numbers = input.split("[^0-9.]+");
        String[] signs = input.split("[0-9. ]+");

        //System.out.println(Arrays.toString(signs)+"-->"+signs.length);
        double sum = 0;
        Double[] realNumbers = new Double[numbers.length];
        for (int i = 0; i < realNumbers.length; i++) {
            realNumbers[i]=Double.parseDouble(signs[i]+numbers[i]);
            if(realNumbers[i]>=0){
                sum+=realNumbers[i];
            }else{
                sum=sum+realNumbers[i];
            }
        }
        System.out.printf("%.7f",sum);
    }
}
