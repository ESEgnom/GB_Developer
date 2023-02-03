import java.util.Random;

public class Field {
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

    public int[] generateBlocks(){
        Random rnd = new Random();
        int point = rnd.nextInt(13,69 );
        int nPoint = rnd.nextInt(51, 89);
        int[] blocks = new int[11];
        blocks[0] = point;
        int count = 0;
        int newPoint = point;
        for (int i = 1; i < blocks.length; i++) {
            if(count <= 3){
                blocks[i] = newPoint + 10;
                newPoint += 10;
                count++;
            }else if(count <= 7){
                blocks[i] = point + 1;
                point += 1;
                count += 1;
            }
        }
        blocks[7] = newPoint;
        count = 0;
        newPoint = nPoint;
        for (int i = 6; i < blocks.length; i++) {
            if(count <= 2){
                blocks[i] = newPoint - 10;
                newPoint -= 10;
                count++;
            }else if(count <= 4){
                blocks[i] = nPoint - 1;
                nPoint -= 1;
                count += 1;
            }
        }
        return blocks;
    }
}
