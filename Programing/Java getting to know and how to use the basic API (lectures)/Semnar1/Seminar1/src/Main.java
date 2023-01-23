import java.lang.reflect.Array;
import java.util.InputMismatchException;
import java.util.Scanner;

/**
 * Дан массив чисел, требуется получить новую выборку только чисел
 */
public class Main {
    public static void main(String[] args) {

        printArray(filtrEven(creatArray()));
    }

    public static int[] creatArray(){
        Scanner scn = new Scanner(System.in);

        int[] res = new int[10];
        try {
            for (int i = 0; i < res.length; i++) {
                System.out.println("Введи натуральное число: ");
                res[i] = scn.nextInt();
            }
        }catch (InputMismatchException e){
            System.out.println("Ввести нужно натуральное число");
            creatArray();
        }

        return res;
    }

    public static int[] filtrEven(int[] arr){
        int[] temp = new int[arr.length];
        int count = 0;
        for (int i = 0; i < arr.length; i++) {
            if(arr[i] % 2 == 0){
                temp[count] = arr[i];
                count++;
            }
        }
        int[] res = new int[count];
        for(int i = 0; i < count; i++) {
            res[i] = temp[i];
        }
        return res;
    }

    public static void printArray(int[] arr){
        System.out.println(arr.toString());
    }
}
