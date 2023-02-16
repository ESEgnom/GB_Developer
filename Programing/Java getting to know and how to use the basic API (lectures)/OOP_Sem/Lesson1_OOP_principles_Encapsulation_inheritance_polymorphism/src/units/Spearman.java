package units;

public class Spearman extends Unit{
    public Spearman(String name) {
        super(name, 175, 50, "spear", 30);
    }

    public String spear(Unit unit){
        String msg = "%s ударил копьем %s. %s";
        return String.format(msg, super.getName(), unit.getName(), super.makeDamage(unit));
    }
    @Override
    public String getInfo(){
        return String.format("Я, Копейщик %s", this.getName());
    }
    @Override
    public String step(){
        return "Сделал шаг";
    }
}
