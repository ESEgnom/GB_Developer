public class FieldGenerator {
    private int[] field;
    private int[] setBlocks = new BlockGenerator().generateBlocks();
    private int block = new Block().getBlock();

    public FieldGenerator() {
        int[] field = createField(100);
        for (int i = 0; i < field.length; i++) {
            field[i] = 00;
            for (int j = 0; j < setBlocks.length; j++) {
                if(i == setBlocks[j]){
                    field[i] = block;
                }
            }
        }
        this.field = field;
    }

    public int[] createField(int range){
        return new int[range];
    }

    public int[] getField() {
        return field;
    }

    public void setStartPoint(Point startPoint){
        field[startPoint.getCoordPoint()] = 1;
    }

}

