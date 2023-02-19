package units;

public class Sorcerer extends Magician{
    private int manaPoints;

    public Sorcerer(String name) {
        super(name, 300, 5, "staff", 25, 100 );
    }
    @Override
    public String getInfo(){
        return String.format("Я, Маг %s", this.getName());
    }
    @Override
    public String step(){
        return "Сделал шаг";
    }
}
