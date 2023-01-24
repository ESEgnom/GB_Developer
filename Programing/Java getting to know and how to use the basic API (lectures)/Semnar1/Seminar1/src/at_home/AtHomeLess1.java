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
            return (num * (num + 1)) / 2;
        }
    }
    public static int getN(){
        Scanner scn = new Scanner(System.in);
        System.out.print("Введи натуальное число: ");
        while (!scn.hasNextInt()){
            System.out.print("Ввести нужно натуральное число: ");
            scn.next();
        }
        return scn.nextInt();
    }
}
