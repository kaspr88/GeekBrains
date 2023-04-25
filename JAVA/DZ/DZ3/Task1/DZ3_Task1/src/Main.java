/*
 * Пусть дан произвольный список целых чисел, удалить из него четные числа
 * */

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        int count = 10;
        System.out.println(endList(randomNumberList(count)));
    }

    public static List randomNumberList(int count) {
        ArrayList<Integer> randomNumber = new ArrayList<>(count);
        Random random = new Random();
        for (int i = 0; i < count; i++) {
            int rand = random.nextInt(0, 20);
            randomNumber.add(rand);
        }
        System.out.println(randomNumber);
        return randomNumber;
    }
     public static List endList(List random){
        ArrayList<Integer> newList = new ArrayList<>();
         for (Object num: random) {
             if((int)num % 2 != 0){
                 newList.add((int)num);
             }
         }
        return newList;
     }

}