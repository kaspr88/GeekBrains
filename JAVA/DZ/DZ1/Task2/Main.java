
/*
 * Вычислить n! (произведение чисел от 1 до n)
 */
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("Введите n: ");
        int num = in.nextInt();
        int res = 1;
        for (int i = 1; i <= num; i++) {
            res = res * i;
            System.out.println(i);
        }
        System.out.println(res);
    }
}
