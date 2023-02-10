public class FieldPrinter {

    public void print(int[] field){
        int size = field.length;
        System.out.println(size);
        int count = 10;
        for (int i = 0; i < field.length; i++) {
            if (i == count){
                System.out.println();
                count += 10;
            }
            if (field[i] == -1){
                System.out.printf(" %s ", field[i]);
            }else {
                System.out.printf("  %s ", field[i]);
            }
        }
        System.out.println();
    }
    public String showField(int[] field, int finishPoint){
        int count = 10;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < field.length; i++) {
            if(i == count){
                sb.append("\n");
                count +=10;
            }
            switch (field[i]){
                case -1:
                    sb.append(" \uD83D\uDFEB");
                    break;
                case -3, 1:
                    sb.append(" \uD83D\uDFE5");
                    break;
                default:
                    if(i == finishPoint){
                        sb.append(" \uD83D\uDFEA");
                    }else{
                    sb.append(" \uD83D\uDFE9");
                    }
            }


        }
        return sb.toString();
    }
}
