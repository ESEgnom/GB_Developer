import java.util.LinkedList;
import java.util.Queue;
import java.util.Scanner;

/**
 * Класс реализует курсор.
 * @Методы: {@link #findWays(int[])} - Просчитывает возможные пути.
 * @* {@link #getStartPoint()} - Запрашивает у пользователя ввод в консоль стартовой координаты в виде целого положительного числа 0 - 99
 * @* {@link #stepUp(int[], Queue, int, int)} - Реализует проверку на возможность сделать ход в верх,
 * если ход возможен записывает в ячейку "поля" номер следующего шага.
 * @* {@link #stepLeft(int[], Queue, int, int)} - Реализует проверку на возможность сделать ход влево,
 *  * если ход возможен записывает в ячейку "поля" номер следующего шага.
 * @* {@link #stepDown(int[], Queue, int, int)} - Реализует проверку на возможность сделать ход вниз,
 *  *  * если ход возможен записывает в ячейку "поля" номер следующего шага.
 * @* {@link #stepRight(int[], Queue, int, int)} - Реализует проверку на возможность сделать ход вправо,
 *  *  *  * если ход возможен записывает в ячейку "поля" номер следующего шага.
 */
public class Cursor {

    public void findWays(int[] field) {
        Queue<Integer> moves = new LinkedList<>();
       int startPoint = getStartPoint();
        moves.add(startPoint);

        field[startPoint] = 1;

        int nextPoint = 2;

        while (!moves.isEmpty()) {
            Integer[] movesArr;
            movesArr = moves.toArray(new Integer[0]);
            for (int move : movesArr) {
                if (field[move] == nextPoint - 1) {
                    stepUp(field, moves, move, nextPoint);
                    stepRight(field, moves, move, nextPoint);
                    stepDown(field, moves, move, nextPoint);
                    stepLeft(field, moves, move, nextPoint);
                    moves.remove();
                }
            }
            nextPoint++;
        }
    }

    public static int getStartPoint() {
        Scanner scn = new Scanner(System.in);
        System.out.println("Введи точку с которой хочешь стартовать (число 0 - 99)");
        int startPoint = scn.nextInt();
        scn.close();
        return startPoint;
    }

    public static void stepUp(int[] field, Queue moves, int move, int nextPoint){
        if (move - 10 >= 0 && field[move - 10] == 0) {
            field[move - 10] = nextPoint;
            moves.add(move - 10);
        }
    }

    public static void stepLeft(int[] field, Queue moves, int move, int nextPoint){
        if (move - 1 >= 0 && field[move - 1] == 0) {
            switch (move - 1){
                case 9, 19, 29, 39, 49, 59, 69, 79, 89:
                    break;
                default:
                    field[move - 1] = nextPoint;
                    moves.add(move - 1);
            }
        }
    }

    public static void stepRight(int[] field, Queue moves, int move, int nextPoint){
        if (move + 1 <= 99 && field[move + 1] == 0) {
            field[move + 1] = nextPoint;
            moves.add(move + 1);
        }
    }

    public static void stepDown(int[] field, Queue moves, int move, int nextPoint){
        if (move + 10 <= 99 && field[move + 10] == 0) {
            field[move + 10] = nextPoint;
            moves.add(move + 10);
        }
    }





}
