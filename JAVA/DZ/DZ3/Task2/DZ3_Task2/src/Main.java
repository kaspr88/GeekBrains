
/*
*Задан целочисленный список ArrayList. Найти минимальное, максимальное и среднее
*арифметическое из этого списка. Collections.max()
*/

import java.util.*;

public class Main {
    public static void main(String[] args) {

        arithmeticValues(randomList(10));
    }
    public static List<Integer> randomList(int count){
        Random random = new Random();
        ArrayList randomArray = new ArrayList<>(count);
        for (int i = 0; i < count; i++) {
            randomArray.add(random.nextInt(0,20));
        }
        Collections.max(randomArray);
        return  randomArray;
    }
    public static void arithmeticValues(List randomList){
        System.out.println(randomList);
        System.out.println("max value: "+Collections.max(randomList));
        System.out.println("min value: "+Collections.min(randomList));
        int arithmeticMean =0;
        for (Object num: randomList) {
            arithmeticMean = (arithmeticMean+(int)num);
        }
        System.out.println("mean value: "+arithmeticMean/randomList.size());


    }
}
