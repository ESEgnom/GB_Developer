public class Main {
    public static void main(String[] args) {
        Field field = new Field();
        Cursor cursor = new Cursor();
        int[] newfield = field.createField();
        field.showField(newfield);
        cursor.findWays(newfield);
        field.showField(newfield);

    }
}