package AtHome;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

public class App {
    public static void main(String[] args) throws IOException {
        InputRead inputRead = new InputRead("D:\\Documents\\Repositories\\GB_Developer\\Programing\\Java getting to know and how to use the basic API (lectures)\\Seminar2\\src\\AtHome/input.txt");
        PowAndWrite pw = new PowAndWrite();

        pw.calculation(inputRead.dataRead("a"), inputRead.dataRead("b"));
    }
}
