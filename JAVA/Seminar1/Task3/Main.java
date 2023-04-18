package JAVA.Seminar1.Task3;

import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        int[] nums = new int[]{3,2,5,3};
        int[] our_result = getResultArray(nums, 3);
        System.out.println(Arrays.toString(nums));
        System.out.println(Arrays.toString(our_result));
    }

    static int[] getResultArray(int[] temp, int condition) {
        int size = temp.length;
        int[] result = new int[size];

        Arrays.fill(result, condition);

        for (int i = 0, j =0; i < size; i++) {
            if (temp[i] != condition) {
                result[j++] = temp[i];
            }
        }

        return result;
    }
}
