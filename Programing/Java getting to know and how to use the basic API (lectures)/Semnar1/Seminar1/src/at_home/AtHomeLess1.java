package at_home;

import java.util.Scanner;

public class AtHomeLess1 {
    public static void main(String[] args) {
        int n = getN();
        System.out.print("Найденное треугольное число = " + findTriangleNum(n));
    }
    public static int findTriangleNum(int num){
        if(num == 1){
            return 1;
        }else{
            int result = (num * (num + 1)) / 2;
            return result;
        }
    }
    public static int getN(){
        Scanner scn = new Scanner(System.in);
        System.out.print("Введи натуальное число: ");
        int num = scn.nextInt();
        scn.close();
        return num;
    }
}
