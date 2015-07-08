package _5_CSharpExams;

import java.util.Scanner;

/**
 * Created by veronica on 26.01.15.
 */
public class _03_Beers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int beers=0;
        int stacks = 0;
        int totalBeers=0;
        String intput = sc.nextLine();

        while (!intput.equals("End")){
            String[] values = intput.split(" ");
            int count = Integer.parseInt(values[0]);
            String type = values[1];

            if(type.equals("stacks")){
                stacks+=count;
            }else if(type.equals("beers")){

                beers+=count;
                if(beers>=20){
                    stacks+=beers/20;

                    beers%=20;
                }
            }

            intput=sc.nextLine();
        }

        System.out.println(stacks+" stacks " +"+ "+beers + " beers");
    }
}

//        while(!intput.equals("End")){
//            String [] separate = intput.split(" ");
//            int count= Integer.parseInt(separate[0]);
//            String type = separate[1];
//            if(type.equals("stacks")) {
//                totalBeers = totalBeers + count * 20;
//            }else{
//                totalBeers+=count;
//            }
//
//            intput=sc.nextLine();
//        }
//        stacks=totalBeers/20;
//        beers=totalBeers%20;
//        System.out.println(stacks+" stacks " +"+ "+beers + " beers");
