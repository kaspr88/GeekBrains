import java.util.Collection;
import java.util.Collections;
import java.util.LinkedList;

/*
 * Пусть дан LinkedList с несколькими элементами. Реализуйте метод, который вернет “перевернутый” список.
 * Постараться не обращаться к листу по индексам.
 * */
public class Main {
    public static void main(String[] args) {
        reverseList();
    }

    public static void reverseList() {
        LinkedList<Integer> list = new LinkedList<>();
        list.add(1);
        list.add(2);
        list.add(3);
        list.add(4);

        for (int i = 0; i < 4; i++) {
            System.out.print((list.get(list.size() - (i + 1)) + ", "));

        }

    }
}