/*
 * Вычислить n! (произведение чисел от 1 до n)
 */
import java.util.Scanner;
public class program1 {
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("Введите n: ");
        int num = in.nextInt();
        int res = 0;
        for(int i=0;i<num; i++){
            res = res*i;
        }
        System.out.println(res);
    }
}
