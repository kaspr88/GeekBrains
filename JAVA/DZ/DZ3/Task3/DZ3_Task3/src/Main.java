import java.util.*;

/*
 *Заполнить список названиями планет Солнечной системы в произвольном порядке с повторениями.
 * Меркурий, Венера, Земля, Марс, Юпитер, Сатурн, Уран, Нептун, Плутон.
 * Вывести название каждой планеты и количество его повторений в списке.
 */
public class Main {
    public static void main(String[] args) {
        planets();
    }

    public static List planets() {
        ArrayList<String> listPlanets = new ArrayList<>(List.of("Уран", "Меркурий",  "Венера", "Земля", "Марс", "Меркурий", "Юпитер", "Меркурий", "Сатурн", "Юпитер", "Уран", "Нептун", "Плутон", "Венера"));
        Collections.sort(listPlanets);
        Set<String> printed = new HashSet<>();
        for (String s : listPlanets) {
            if (printed.add(s))
                System.out.print(s + " " + Collections.frequency(listPlanets, s) + " ");
        }
        return null;
    }

}