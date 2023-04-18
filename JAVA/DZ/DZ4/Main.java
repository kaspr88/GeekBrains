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
        String operation = in.nextLine();
        if (operation == "+") {
            System.out.println(n + m);
        } else if (operation == "-") {
            System.out.println(n - m);
        } else if (operation == "*") {
            System.out.println(n * m);
        } else if (operation == "/") {
            System.out.println(n / m);
        }

    }

}
