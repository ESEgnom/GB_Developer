package App;

import java.util.Scanner;

public class EntryPoint {
    public static int numberEntry() {


        boolean isReady = false;
        int n = 0;
        String inputError = "Ошибка!!!\nВведите число больше или равное нулю.";
        String inputErrorStr = "Ошибка!!! Вы ввели не число!!!\nВведите число больше или равное нулю.";
        while (!isReady) {
            try {
                Scanner scanner = new Scanner(System.in);
                n = scanner.nextInt();
                if (n >= 0)
                    isReady = true;
                else
                    System.out.println(inputError);
            } catch (Exception e) {
                System.out.println(inputErrorStr);
            }
        }
        return n;
    }
}
