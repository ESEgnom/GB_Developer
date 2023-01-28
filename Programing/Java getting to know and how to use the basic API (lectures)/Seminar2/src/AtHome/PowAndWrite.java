package AtHome;

import java.io.FileWriter;
import java.io.IOException;

public class PowAndWrite {
    public void calculation (int a, int b){

        try (FileWriter fw = new FileWriter("output.txt", false)){
            if (a == 0 && b == 0){
                fw.write("не определено");
                fw.close();
            }else{
                fw.write(String.format("a = %s возведнная в степень b = %s -> %s", a, b, Math.pow(a, b)));
            }
        }catch (IOException ex){
            System.out.println(ex.getMessage());
        }
    }
}
