package AtHome;

import java.io.IOException;


public class App {
    public static void main(String[] args) throws IOException {
        InputRead inputRead = new InputRead("input.txt");
        PowAndWrite pw = new PowAndWrite();


        pw.calculation(inputRead.dataRead("a"), inputRead.dataRead("b"));
    }
}
