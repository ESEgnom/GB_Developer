package units;

public class Sniper extends Unit{
    private int numberOfArrows;
    public Sniper(String name) {
        super(name, 150, 25, "bow", 15);
        this.numberOfArrows = 30;
    }

    public String shootABow(Unit unit){
        if(this.numberOfArrows == 0){
            return String.format("%s не может выстрелить из лука. Закончились стрелы");
        }else{
            String msg = "%s Выстрелил в %s. %s";
            this.numberOfArrows -= 1;
            super.makeDamage(unit);
            return String.format(msg, super.getName(), unit.getName(), super.makeDamage(unit));
        }
    }
    @Override
    public String getInfo(){
        return String.format("Я, Лучник %s", this.getName());
    }
    @Override
    public String step(){
        return "Сделал шаг";
    }
}
