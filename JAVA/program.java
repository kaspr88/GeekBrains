/**
 * Вычислить n-ое треугольного число (сумма чисел от 1 до n)
 * 1/2*n(n+1)
 */
import java.util.Scanner;
public class program {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("Введите n: ");
        int n = in.nextInt();
        int result = (n*(n+1))/2;
        System.out.println(result);
    }



    
}