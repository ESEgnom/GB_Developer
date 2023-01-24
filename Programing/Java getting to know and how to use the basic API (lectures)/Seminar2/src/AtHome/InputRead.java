package AtHome;

import java.io.*;
import java.util.ArrayList;

public class InputRead {
    private String path;
    private BufferedReader bf;
    private ArrayList<String> str;
    private String receivedData;
    private int itemA, itemB;

    public InputRead(String path) {
        this.path = path;
    }

    public int dataRead(String var) throws IOException{
        str = new ArrayList<>();
        bf = new BufferedReader(new FileReader(path));
        while ((receivedData = bf.readLine()) != null){
            str.add(receivedData);
        }
        bf.close();
        System.out.printf("24 %s\n", str.toString());

        for (String item: str) {
            if (item.contains("a")) {
                System.out.printf("28 %s\n", item);
                itemA = Integer.parseInt(item.replaceAll("\\D+", ""));
                System.out.printf("29 %s \n", itemA);
                return itemA;
            }else if (item.contains("b")) {
                System.out.printf("33 %s\n", item);
                itemB = Integer.parseInt(item.replaceAll("\\D", ""));
                System.out.printf("34 %s\n", itemB);
                return itemB;
            }
        }
        if(var.equals("a")){
            return itemA;
        }else{
            return itemB;
        }
    }
}
