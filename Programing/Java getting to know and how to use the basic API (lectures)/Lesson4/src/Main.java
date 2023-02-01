import java.util.*;

public class Main {
    public static void main(String[] args) {
        int[] newfield = createField(100);
        printField(newfield);

        findWays(newfield);

    }

    public static int[] createField(int range) {
        int[] field = new int[range];
        int[] blocks = {23, 33, 35, 36, 43, 46, 52, 53, 56, 66, 67};
        for (int i = 0; i < field.length; i++) {
            for (int block : blocks) {
                if (i == block) {
                    field[i] = -1;
                    break;
                }
            }
        }
        return field;
    }

    public static void printField(int[] field) {
        int count = 9;
        for (int i = 0; i < field.length; i++) {
            if (field[i] == -1 || 10 <= field[i]) {
                System.out.printf("%s ", field[i]);
            } else {
                System.out.printf(" %s ", field[i]);
            }
            if (i == count) {
                System.out.println();
                count += 10;
            }
        }
        System.out.println();
    }

    public static void findWays(int[] field) {
        Queue<Integer> moves = new LinkedList<>();
        int startPoint = getStartPoint();
        moves.add(startPoint);

        System.out.println(moves);

        field[startPoint] = 1;

        int nextPoint = 2;

        while (!moves.isEmpty()) {
            Integer[] movesArr;
            movesArr = moves.toArray(new Integer[0]);
            for (int move : movesArr) {
                if (field[move] == nextPoint - 1) {
                    if (move - 10 >= 0 && field[move - 10] == 0) {
                        field[move - 10] = nextPoint;
                        moves.add(move - 10);
                        printField(field);
//                        sleep();
                    }
                    if (move + 1 <= 99 && field[move + 1] == 0) {
                        field[move + 1] = nextPoint;
                        moves.add(move + 1);
                        printField(field);
//                        sleep();
                    }
                    if (move + 10 <= 99 && field[move + 10] == 0) {
                        field[move + 10] = nextPoint;
                        moves.add(move + 10);
                        printField(field);
//                        sleep();
                    }
                    if (move - 1 >= 0 && field[move - 1] == 0) {
                        switch (move - 1){
                            case 9, 19, 29, 39, 49, 59, 69, 79, 89:
                                break;
                            default:
                                field[move - 1] = nextPoint;
                                moves.add(move - 1);
                                printField(field);
//                                sleep();
                        }
                    }
                    moves.remove();
                }
            }
            nextPoint++;
        }
    }

    public static int getStartPoint(){
        Scanner scn = new Scanner(System.in);
        System.out.println("Введи точку с которой хочешь стартовать (число 0 - 99)");
        int point = scn.nextInt();
        scn.close();
        return point;
    }

//    public static void sleep(){
//        try {
//            Thread.sleep(1000);
//        } catch (InterruptedException e) {
//            System.out.println("Чет какая то хрень тут произошла, \n\"Возможно это какой то дикий зверь. Или несколько зверей\" ©️ \"Мертвые не умираю\" ");
//        }
//    }

}