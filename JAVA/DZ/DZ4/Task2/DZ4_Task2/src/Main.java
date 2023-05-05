import java.util.LinkedList;

/*
 * Реализуйте очередь с помощью LinkedList со следующими методами: enqueue() -
 * помещает элемент в конец очереди, dequeue() - возвращает первый элемент из очереди и удаляет его,
 * first() - возвращает первый элемент из очереди, не удаляя.
 */
public class Main {
    public static void main(String[] args) {

        MyClass queue = new MyClass();
        queue.enqueue(5);
        queue.enqueue(7);
        queue.enqueue(6);
        queue.enqueue(8);
        System.out.println(queue.dequeue());
        System.out.println(queue.first());


    }

}