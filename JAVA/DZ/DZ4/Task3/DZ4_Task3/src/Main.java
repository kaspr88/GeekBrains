import java.util.Iterator;
import java.util.LinkedList;

/*
 * Найдите сумму всех элементов LinkedList, сохраняя все элементы в списке. Используйте итератор
 * */
public class Main {
    public static void main(String[] args) {

        raversList(random());

    }

    public static void raversList(LinkedList<Integer> ll) {
        Iterator iterator = ll.iterator();
        int sumElement = 0;
        while (iterator.hasNext()) {
            sumElement = sumElement + (int) iterator.next();
        }
        System.out.println(sumElement);
    }

    public static LinkedList<Integer> random() {
        LinkedList<Integer> rll = new LinkedList<>();
        for (int i = 0; i < 10; i++) {
            rll.addLast((int) (Math.random() * 10));
        }
        System.out.println(rll);

        return rll;
    }
}