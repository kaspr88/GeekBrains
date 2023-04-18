package JAVA.Seminar1.Task4;

public class Main {
    public static String main(String[] args) {
    
        String res = "";
        String text;
        String[] temp = text.split(" ");
        for (int i = temp.length-1; i >= 0; i--) {
            res += temp[i] + " ";
        }
        return res;
    }
    }
}
