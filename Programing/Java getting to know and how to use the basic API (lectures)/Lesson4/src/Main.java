public class Main {
    public static void main(String[] args) {
        Point startP = new Point(1);
        Point finishP = new Point(86);

        FieldGenerator fg = new FieldGenerator();
        FieldPrinter fieldPrinter = new FieldPrinter();

        fg.setStartPoint(startP);
        int[] field = fg.getField();
        Cursor cursor = new Cursor(field);
        System.out.println(fieldPrinter.showField(field, finishP.getCoordPoint()));

        cursor.findWays(startP.getCoordPoint());
        cursor.findShortestWay(finishP.getCoordPoint());
        System.out.println(fieldPrinter.showField(field, finishP.getCoordPoint()));



    }
}