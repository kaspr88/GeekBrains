import java.util.LinkedList;

public class MyClass {
    private LinkedList<Integer> queue = new LinkedList<>();

    void enqueue(int num) {
        queue.addLast(num);
    }

    int dequeue() {
        int num = queue.get(0);
        queue.remove(0);
        return num;
    }

    int first() {
        int num = queue.get(0);
        return num;
    }

}
