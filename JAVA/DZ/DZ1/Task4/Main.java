/*
 * Реализовать простой калькулятор (введите первое число, введите второе число, введите требуемую операцию, ответ)
 */

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int n = in.nextInt();
        System.out.print("Введите второе число: ");
        int m = in.nextInt();
        System.out.print("Введите требуемую операцию: ");
        char peration = in.next().charAt(0);
        in.close();
        int num = Calculate(n, m, peration);
        System.out.println(num);

    }

    public static Integer Calculate(int n, int m, char operation) {
        int res = 0;
        if (operation == '+') {
            res = n + m;
        } else if (operation == '-') {
            res = n - m;
        } else if (operation == '*') {
            res = n * m;
        } else if (operation == '/') {
            res = n / m;
        }
        return res;
    }

}
