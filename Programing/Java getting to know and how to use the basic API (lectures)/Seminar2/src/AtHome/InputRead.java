package AtHome;

import java.io.*;
import java.util.ArrayList;

public class InputRead {
    private final String path;
    private int itemA, itemB;

    public InputRead(String path) {
        this.path = path;
    }
    public int dataRead(String var) throws IOException{
        ArrayList<String> str = new ArrayList<>();
        BufferedReader bf = new BufferedReader(new FileReader(path));
        String receivedData;
        while ((receivedData = bf.readLine()) != null){
            str.add(receivedData);
        }
        bf.close();
        for (String item: str) {
            if (item.contains("a")) {
                itemA = Integer.parseInt(item.replaceAll("\\D", ""));
            }else if (item.contains("b")) {
                itemB = Integer.parseInt(item.replaceAll("\\D", ""));
            }
        }
        if(var.equals("b")){
            return itemB;
        }else{
            return itemA;
        }
    }
}
