import java.io.*;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

public class Main {

    private final static Logger log = Logger.getAnonymousLogger();

    public static void main(String[] args) {
        String st = "[{\"фамилия\":\"Иванов\",\"оценка\":\"5\",\"предмет\":\"Математика\"},{\"фамилия\":\"Петрова\",\"оценка\":\"4\",\"предмет\":" +
                "\"Информатика\"},{\"фамилия\":\"Краснов\",\"оценка\":\"5\",\"предмет\":\"Физика\"}]";

        loger();
        fileAdd();
        fileSave(st);
        reparse(fileRead());
        log.getHandlers()[0].close();
    }

    public static void fileAdd() {

        try {
            File newFile = new File("file.txt");
            if (newFile.createNewFile()) {
                log.log(Level.INFO, "Файл создан");
            } else {
                log.log(Level.INFO, "Файл найден");
            }
            ;
        } catch (Exception ex) {
            System.out.println(ex);
        }

    }

    public static void fileSave(String st) {
        try (FileWriter fw = new FileWriter("file.txt", false);) {
            fw.write(st);
            fw.flush();
            log.log(Level.INFO, "Данные записаны в файл");
        } catch (Exception ex) {
            System.out.println(ex);
            log.log(Level.INFO, String.valueOf(ex));
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
            log.log(Level.INFO, "Файл считан");
        } catch (Exception ex) {
            System.out.println(ex);
            log.log(Level.INFO, String.valueOf(ex));
        }
        return (sb);
    }

    public static void reparse(StringBuilder sb) {
        String rep = sb.substring(2, sb.length() - 2).replace("},{", ",").replace("\"", "");
        String[] arr = rep.split(",");
        String[][] arr2 = new String[arr.length][];
        for (int i = 0; i < arr2.length; i++) {
            arr2[i] = (arr[i].split(","));
            arr2[i] = (arr[i].split(":"));
        }
        String[] arr3 = {"Студент ", "получил ", "по предмету "};
        int count = 0;
        for (int i = 0; i < arr2.length; i++) {
            System.out.print(arr3[count] + arr2[i][1] + " ");
            count++;
            if (count == 3) {
                count = 0;
                System.out.println("");
            }
        }
        log.log(Level.INFO, "Данные выведены в консоль");
    }

    public static void logger() {
        try {
            FileHandler fh = null;
            fh = new FileHandler("log.txt");
            SimpleFormatter formatter = new SimpleFormatter();
            fh.setFormatter(formatter);
            log.addHandler(fh);
        } catch (IOException e) {
            throw new RuntimeException(e);
        }

    }
}


