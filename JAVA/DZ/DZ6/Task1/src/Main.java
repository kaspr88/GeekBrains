import java.io.IOException;
import java.util.*;

/*Подумать над структурой класса Ноутбук для магазина техники - выделить поля и методы. Реализовать в java.
Создать множество ноутбуков.
Написать метод, который будет запрашивать у пользователя критерий (или критерии) фильтрации и выведет ноутбуки,
отвечающие фильтру. Критерии фильтрации можно хранить в Map. Например: “Введите цифру, соответствующую необходимому критерию:
1 - ОЗУ
2 - Объем ЖД
3 - Операционная система
4 - Цвет …
Далее нужно запросить минимальные значения для указанных критериев - сохранить параметры фильтрации можно также в Map.
Отфильтровать ноутбуки из первоначального множества и вывести проходящие по условиям.
*/
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


        Scanner sc = new Scanner(System.in);
        System.out.print(
                "1 - ОЗУ\n" +
                        "2 - Объем ЖД\n" +
                        "3 - Операционная система\n" +
                        "4 - Цвет\n" +
                        "Сделайте выбор:");
        String variant = sc.nextLine();
        Map<String, String> userConfig = new HashMap();

        switch (variant) {
            case "1":
                Set<Integer> Ram = new HashSet<>();
                for (Notebook noteBook : NoteBooks
                ) {
                    Ram.add(noteBook.getRam());
                }
                int countRam = 1;
                for (int ram : Ram) {
                    System.out.println(countRam + " - " + ram);
                    countRam++;
                }
                System.out.print("Введите интересующее значение из имеющихся:");
                Scanner scRam = new Scanner(System.in);
                int variantRam = (scRam.nextInt());
                for (int ramResult : Ram) {
                    if (ramResult == variantRam) {
                        userConfig.put(variant, String.valueOf(variantRam));
                        UserBook userBook = new UserBook(ramResult,);
                    }
                }
                break;
            case "2":
                Set<Integer> Rom = new HashSet<>();
                for (Notebook noteBook : NoteBooks
                ) {
                    Rom.add(noteBook.getRom());
                }
                int countRom = 1;
                for (int ram : Rom) {
                    System.out.println(countRom + " - " + ram);
                    countRom++;
                }
                System.out.print("Введите интересующее значение из имеющихся:");
                Scanner scRom = new Scanner(System.in);
                int variantRom = (scRom.nextInt());
                for (int romResult : Rom) {
                    if (romResult == variantRom) {
                        userConfig.put(variant, String.valueOf(variantRom));
                    }
                }
                break;
            case "3":
                Set<String> OS = new HashSet<>();
                for (Notebook noteBook : NoteBooks
                ) {
                    OS.add(noteBook.getOS());
                }
                int countOS = 1;
                for (String os : OS) {
                    System.out.println(countOS + " - " + os);
                    countOS++;
                }
                System.out.print("Введите интересующее значение из имеющихся:");
                Scanner scOS = new Scanner(System.in);
                String variantOS = (scOS.nextLine());
                for (String osResult : OS) {
                    if (osResult.equals(variantOS)) {
                        userConfig.put(variant, variantOS);
                    }
                }
                break;
            case "4":
                Set<String> Color = new HashSet<>();
                for (Notebook noteBook : NoteBooks
                ) {
                    Color.add(noteBook.getColor());
                }
                int countColor = 1;
                for (String color : Color) {
                    System.out.println(countColor + " - " + color);
                    countColor++;
                }
                System.out.print("Введите интересующее значение из имеющихся:");
                Scanner scColor = new Scanner(System.in);
                String variantColor = (scColor.nextLine());
                for (String colorResult : Color) {
                    if (colorResult.equals(variantColor)) {
                        userConfig.put(variant, variantColor);
                    }
                }
                break;
            default:
                System.out.println("число не равно 1, 8, 9");


        }


        for (Notebook notebook : NoteBooks) {
            if (notebook.getRam()==(UserBook.userRam())) {
                if (notebook.getRom() == UserBook.userRom()) {
                    if (notebook.getOS().equals(UserBook.userOS())) {
                        if (notebook.getColor().equals(UserBook.userColor())) {
                            System.out.println("Найдено: " + notebook);
                            break;
                        }
                    } else {
                        System.out.println("Такой конфигурации нет в базе!");
                    }

                }
            }
        }


            }
        }


