package _03_JavaCollections;

import java.util.Scanner;
import java.util.TreeMap;

/**
 * Created by veronica on 25.01.15.
 */
public class _17_LogsAggregator {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        sc.nextLine();
        TreeMap<String,TreeMap<String,Integer>> result = new TreeMap<String, TreeMap<String,Integer>>();


        for (int i = 0; i <n ; i++) {
            String[] line = sc.nextLine().split(" ");
            String ip = line[0];
            String name = line[1];
            Integer duration = Integer.parseInt(line[2]);

            TreeMap<String, Integer> durationAndIp= new TreeMap<String, Integer>();

            if(result.containsKey(name)){
                if(result.get(name).containsKey(ip)){
                    int prevDuration = result.get(name).get(ip);
                    duration += prevDuration;
                }
                result.get(name).put(ip, duration);
            }else{
                durationAndIp.put(ip, duration);
                result.put(name,durationAndIp);
            }
        }
        for (String name : result.keySet()) {
            int sum = 0;
            System.out.print(name+": ");
            String[] sums = result.get(name).values().toString().replace("[","").replace("]","").split(", ");
            for (int i = 0; i < sums.length; i++) {
                sum+=Integer.parseInt(sums[i]);
            }
            System.out.print(sum+" ");
            System.out.println(result.get(name).keySet());

        }
    }
}
