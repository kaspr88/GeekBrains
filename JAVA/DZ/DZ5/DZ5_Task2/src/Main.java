/*
 * Пусть дан список сотрудников: Иван Иванов, Светлана Петрова,
 * Кристина Белова, Анна Мусина, Анна Крутова, Иван Юрин, Петр Лыков,
 * Павел Чернов, Петр Чернышов, Мария Федорова, Марина Светлова,
 * Мария Савина, Мария Рыкова, Марина Лугова, Анна Владимирова,
 * Иван Мечников, Петр Петин, Иван Ежов. Написать программу, которая
 * найдет и выведет повторяющиеся имена с количеством повторений.
 * Отсортировать по убыванию популярности.
 * Для сортировки использовать TreeMap.
 */

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.TreeMap;
public class Main {public static void main(String[] args) {
    String str = "Иван Иванов, Светлана Петрова, Кристина Белова," +
            " Анна Мусина, Анна Крутова, Иван Юрин, Петр Лыков, Павел Чернов," +
            " Петр Чернышов, Мария Федорова, Марина Светлова, Мария Савина," +
            " Мария Рыкова, Марина Лугова, Анна Владимирова, Иван Мечников," +
            " Петр Петин, Иван Ежов.";
    makeSort(str);

}

    static void makeSort(String line) {
        line = line.replace(",", "").replace(".", "");
        String[] peoples = line.split(" ");
        Map<String, Integer> hMap = new HashMap<>();
        for (int i = 0; i < peoples.length; i = i + 2) {
            if (hMap.containsKey(peoples[i])) {
                hMap.put(peoples[i], hMap.get(peoples[i]) + 1);
            } else {
                hMap.put(peoples[i], 1);
            }
        }

        TreeMap<Integer, List<String>> tMap = new TreeMap<>();
        for (var entry : hMap.entrySet()) {
            String name = entry.getKey();
            int count = entry.getValue();
            if (tMap.containsKey(count)) {
                List<String> list = tMap.get(count);
                list.add(name);
            } else {
                List<String> list = new ArrayList<>();
                list.add(name);
                tMap.put(count, list);
            }
        }
        System.out.println(tMap.descendingMap());
    }
}