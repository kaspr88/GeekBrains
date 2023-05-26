import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;

public class Main {

    public static void main(String[] args) {
        Notebook Lenovo = new Notebook(1024, 512, "Linux", "black");
        Notebook Acer = new Notebook(2048, 1024, "Windows 10", "red");
        Notebook HP = new Notebook(2048, 512, "Linux", "gray");
        Notebook Asus = new Notebook(4096, 1024, "Windows 10", "pink");
        Notebook Vivo = new Notebook(8192, 512, "Linux", "black");
        Notebook MacBook = new Notebook(8192, 1024, "MacOS", "white");

        Set<Notebook> NoteBooks = new HashSet<>();
        NoteBooks.add(Lenovo);
        NoteBooks.add(Acer);
        NoteBooks.add(HP);
        NoteBooks.add(Asus);
        NoteBooks.add(Vivo);
        NoteBooks.add(MacBook);

        try {
            Scanner scanner = new Scanner(System.in);

            try {
                System.out.println("Введите oбъём оперативной памяти: ");
                int ram = Integer.parseInt(scanner.nextLine());
                System.out.println("Введите объём жесткого диска: ");
                int rom = Integer.parseInt(scanner.nextLine());
                System.out.println("Введите операционную систему: ");
                String os = scanner.nextLine();
                System.out.println("Введите цвет: ");
                String color = scanner.nextLine();
                UserBook userBook = new UserBook(ram, rom, os, color);
                System.out.println("Ваша конфигурация: " + userBook);

                for (Notebook notebook : NoteBooks) {
                    if (notebook.getRam()==(userBook.userRam())) {
                        if (notebook.getRom() == userBook.userRom()) {
                                if (notebook.getOS().equals(userBook.userOS())) {
                                    if (notebook.getColor().equals(userBook.userColor())) {
                                        System.out.println("Найдено: " + notebook);
                                        break;
                                    }
                                } else {
                                    System.out.println("Такой конфигурации нет в базе!");
                                }

                        }
                    }
                }
            } catch (Throwable var15) {
                try {
                    scanner.close();
                } catch (Throwable var14) {
                    var15.addSuppressed(var14);
                }
                throw var15;
            }
            scanner.close();
        } catch (NumberFormatException var16) {
            var16.printStackTrace();
        }

    }
}