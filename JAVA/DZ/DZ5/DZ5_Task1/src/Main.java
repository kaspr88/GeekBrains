import java.util.HashMap;
import java.util.Scanner;

/*Реализуйте структуру телефонной книги с помощью HashMap, учитывая, что 1 человек может иметь несколько телефонов.
 */
public class Main {
    public static void main(String[] args) {
        searchUser(addUser(), returnUser(addUser()));
    }

    public static HashMap<String, String> addUser() {
        HashMap<String, String> hm = new HashMap<>();
        hm.put("12345678", "Иван Иванов");
        hm.put("23456789", "Светлана Петрова");
        hm.put("34567890", "Анна Мусина");
        hm.put("45678901", "Мария Савина");
        hm.put("56789012", "Петр Чернышов");
        hm.put("67890123", "Петр Чернышов");
        return hm;
    }

    public static String returnUser(HashMap<String, String> phoneList) {
        System.out.println(phoneList);
        Scanner scaner = new Scanner(System.in);
        System.out.print("Введите искомого абонента: ");
        String User = scaner.nextLine();
        return User;
    }

    public static void searchUser(HashMap<String, String> phoneList, String user) {
        int i = 0;
        for (var item : phoneList.entrySet()) {
            if (item.getValue().equals(user)) {
                i++;
                System.out.println(i + ". Номер абонента " + item.getValue() + ": " + item.getKey());
            }
        }
    }
}
