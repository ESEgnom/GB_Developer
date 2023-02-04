public class Main {
    public static void main(String[] args) {
        Field field = new Field();
        Cursor cursor = new Cursor();
        int[] newField = field.createField();
        field.showField(newField);
        int finishPoint = field.getFinishPoint(newField);
        cursor.findWays(newField);
        field.showField(newField);
        cursor.findShortestWay(newField, finishPoint);
        field.showField(newField);
    }
}