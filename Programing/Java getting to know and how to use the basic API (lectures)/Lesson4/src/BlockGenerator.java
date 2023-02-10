import java.util.Random;

public class BlockGenerator {
    private Random rnd = new Random();

    public int[] generateBlocks(){
        int[] defaultSetBlocks = {0,1,2,3,4,5,6,7,8,9,10,19,20,29,30,39,40,49,50,59,60,69,70,79,80,89,90,91,92,93,94,95,96,97,98,99};
        int[] setBlocksFirst = {12, 22, 27, 28, 32, 37, 42, 43, 44, 45, 47, 57, 64, 67, 74, 75, 76, 77};
        int[] setBlocksSecond = {11, 18, 22, 27, 33, 36, 63, 66, 72, 77, 81, 88};
        int[] setBlocksThird = {11, 18, 22, 27, 33, 34, 35, 36, 43, 46, 56, 63, 64, 65, 66, 72, 77, 81, 88};
        int blockSelection = rnd.nextInt(1, 4);
        return switch (blockSelection) {
            case 1 -> setBlocksFirst;
            case 2 -> setBlocksSecond;
            case 3 -> setBlocksThird;
            default -> defaultSetBlocks;
        };
    }
}
