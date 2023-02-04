import java.util.Random;
import java.util.Scanner;

public class Field {
    private Random rnd = new Random();
    private final int range = 100;

    public int[] createField(){
        int[] field = new int[range];
        int[] blocks = generateBlocks();
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

    public void showField(int[] field){
        int count = 9;
        for (int i = 0; i < field.length; i++) {
            if (field[i] == -1 || 10 <= field[i]) {
                System.out.printf("%s ", field[i]);
            } else if (100 == field[i]) {
                System.out.printf("%s", field[i]);
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

    private int[] generateBlocks(){
        int point = rnd.nextInt(13,69 );
        int nPoint = rnd.nextInt(51, 89);
        int[] blocks = new int[12];
        blocks[0] = point;
        int count = 0;
        int newPoint = point;
        for (int i = 1; i < blocks.length; i++) {
            if(count <= 2){
                blocks[i] = newPoint + 10;
                newPoint += 10;
                count++;
            }else if(count <= 7){
                blocks[i] = point + 1;
                point += 1;
                count += 1;
            }
        }
        newPoint = nPoint;
        blocks[7] = newPoint;
        count = 0;

        for (int i = 8; i < blocks.length; i++) {
            if(count <= 1){
                blocks[i] = newPoint - 10;
                newPoint -= 10;
                count++;
            }else if(count <= 3){
                blocks[i] = nPoint - 1;
                nPoint -= 1;
                count += 1;
            }
        }
        return blocks;
    }

    public int getFinishPoint(int[] field){
        Scanner scn = new Scanner(System.in);
        System.out.print("Введи координату конечно точки пути(число 0 - 99): \n");
        int point = -1;
        do{
            point = scn.nextInt();
            if(field[point] != 0) {
                System.out.println("Ты попал в блок. Попробуй другую точку");
            }
        }while (field[point] != 0);
        return point;
    }
}
