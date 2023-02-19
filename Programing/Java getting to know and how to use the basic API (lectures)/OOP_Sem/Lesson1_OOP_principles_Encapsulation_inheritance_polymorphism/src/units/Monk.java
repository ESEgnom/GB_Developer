package units;

public class Monk extends Magician{

    public Monk(String name) {
        super(name, 100, 5, "prayer", 25,75);
    }

    @Override
    public String getInfo(){
        return String.format("Я, Монах %s", this.getName());
    }
    @Override
    public String step(){
        return "Сделал шаг";
    }
}
