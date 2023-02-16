package units;

public class Crossbowman extends Unit{

    private int numberOfBolts;

    public Crossbowman(String name) {
        super(name, 150, 30, "crossbow", 30);
        numberOfBolts = 50;
    }

    public String shootACrossbow(Unit unit){
        if(this.numberOfBolts == 0){
            return String.format("%s не может выстрелить из арбалета. Закончились болты");
        }else{
            String msg = "%s Выстрелил в %s. %s";
            this.numberOfBolts -= 1;
            super.makeDamage(unit);
            return String.format(msg, super.getName(), unit.getName(), super.makeDamage(unit));
        }
    }

    @Override
    public String getInfo(){
        return String.format("Я, Арбалетчик %s", this.getName());
    }
    @Override
    public String step(){
        return "Сделал шаг";
    }

}
