/*Пусть дан список сотрудников: Иван Иванов, Светлана Петрова, Кристина Белова, Анна Мусина, Анна Крутова,
* Иван Юрин, Петр Лыков, Павел Чернов, Петр Чернышов, Мария Федорова, Марина Светлова, Мария Савина, Мария Рыкова,
* Марина Лугова, Анна Владимирова, Иван Мечников, Петр Петин, Иван Ежов. Написать программу, которая найдет и выведет
* повторяющиеся имена с количеством повторений. Отсортировать по убыванию популярности.
* Для сортировки использовать TreeMap.
*/

import java.util.Comparator;
import java.util.TreeMap;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        TreeMap<String, Integer> namePeople = new TreeMap<>();
        String[] staff = {
                "Иван Иванов", "Светлана Петрова", "Кристина Белова", "Анна Мусина", "Анна Крутова", "Иван Юрин",
                "Петр Лыков", "Павел Чернов", "Петр Чернышов", "Мария Федорова", "Марина Светлова",
                "Мария Савина", "Мария Рыкова", "Марина Лугова", "Анна Владимирова",
                "Иван Мечников", "Петр Петин", "Иван Ежов"
        };
        countName(staff, namePeople);
        sortedStaff(namePeople);

    }

    // Функция, считающая кол-во повторений имен сотрудников
    public static void countName(String[] people, TreeMap<String, Integer> namePeople) {
        for (String person : people) {
            String name = person.split(" ")[0];
            if (namePeople.containsKey(name)) {
                namePeople.put(name, namePeople.get(name) + 1);
            } else {
                namePeople.put(name, 1);
            }
        }
    }

    // Функция сотртировки по убыванию популярности имени
    public static void sortedStaff(TreeMap<String, Integer> namePeople) {
        TreeMap<String, Integer> sortedName = namePeople.entrySet().stream()
                .sorted(Comparator.comparingInt(e -> -e.getValue()))
                .collect(Collectors.toMap(
                        TreeMap.Entry::getKey,
                        TreeMap.Entry::getValue,
                        (a, b) -> {
                            throw new AssertionError();
                        },
                        LinkedHashMap::new));

        sortedName.entrySet().forEach(System.out::println);
    }
};
    }
}