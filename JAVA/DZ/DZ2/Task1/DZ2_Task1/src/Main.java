import java.io.*;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Main {
    private final static Logger log =  Logger.getAnonymousLogger();
    FileHandler fh = null;

    {
        try {
            fh = new FileHandler("log.config");
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
    }

    public static void main(String[] args) {
        /*Дана json строка [{ "фамилия":"Иванов","оценка":"5","предмет":"Математика"},{"фамилия":"Петрова","оценка":"4","предмет":"Информатика"},
        {"фамилия":"Краснов","оценка":"5","предмет":"Физика"}]
Задача написать метод(ы), который распарсит строку и выдаст ответ вида:
Студент Иванов получил 5 по предмету Математика.
Студент Петрова получил 4 по предмету Информатика.
Студент Краснов получил 5 по предмету Физика.

Используйте StringBuilder для подготовки ответа

Исходная json строка это просто String !!! Для работы используйте методы String, такие как replace, split, substring и т.д. по необходимости

Создать метод, который запишет результат работы в файл. Обработайте исключения и запишите ошибки в лог файл.
2. *Получить исходную json строку из файла, используя FileReader или Scanner
3. *Реализуйте алгоритм сортировки пузырьком числового массива, результат после каждой итерации запишите в лог-файл.*/
        String st = "[{\"фамилия\":\"Иванов\",\"оценка\":\"5\",\"предмет\":\"Математика\"},{\"фамилия\":\"Петрова\",\"оценка\":\"4\",\"предмет\":" +
                "\"Информатика\"},{\"фамилия\":\"Краснов\",\"оценка\":\"5\",\"предмет\":\"Физика\"}]";
        fileAdd();
        fileSave(st);
        reparse(fileRead());


    }

    public static void fileAdd(){

        Источник: https://java-blog.ru/osnovy/logger-java
        try {
            File newFile = new File("file.txt");
            if (newFile.createNewFile()) {
                log.log(Level.INFO, "Файл создан");
            }else {
                log.log(Level.INFO, "Файл найден");
            };
        }catch (Exception ex){
            System.out.println(ex);
        }

    }
    public static void fileSave(String st) {
        try(FileWriter fw = new FileWriter("file.txt", false);){
            fw.write(st);
            fw.flush();
            log.log(Level.INFO, "Даанные записаны в файл");
        }catch (Exception ex){
            System.out.println(ex);
            log.log(Level.INFO, ex);
        }
    }
    public static StringBuilder fileRead() {

        StringBuilder sb = null;
        try (FileReader fr = new FileReader("file.txt")) {
            sb = new StringBuilder();
            int c = 0;
            while ((c = fr.read()) != -1) {

                sb.append((char) c);
            }
        } catch (Exception ex) {
            System.out.println(ex);
        }
        return (sb);
    }
    public static void reparse(StringBuilder sb) {
        String rep = sb.substring(2,sb.length()-2).replace("},{",",").replace("\"","");
        String[] arr = rep.split(",");
        String[][] arr2 = new String[arr.length][] ;
        for (int i = 0; i < arr2.length; i++) {
            arr2[i]= (arr[i].split(","));
            arr2[i]= (arr[i].split(":"));
        }
        String[] arr3 = {"Студент ", "получил ", "по предмету "};
        int count = 0;
        for (int i = 0; i < arr2.length; i++) {
            System.out.print(arr3[count] +  arr2[i][1] + " ");
            count ++;
            if (count == 3) {
                count =0;
                System.out.println("");
            }
        }
    }



}


