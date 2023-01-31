package App;

public class Main {
    public static void main(String[] args) {
        System.out.println("Введите размер поля M: ");
        int m = EntryPoint.numberEntry();
        System.out.println("Введите размер поля N: ");
        int n = EntryPoint.numberEntry();
        System.out.println("Введите координату точки X: ");
        int x = EntryPoint.numberEntry();
        System.out.println("Введите координату точки Y: ");
        int y = EntryPoint.numberEntry();
        int result = Solution.countPaths(m, n, x, y);
        System.out.println("Количество маршрутов равно: ");
        System.out.println(result);
    }
}