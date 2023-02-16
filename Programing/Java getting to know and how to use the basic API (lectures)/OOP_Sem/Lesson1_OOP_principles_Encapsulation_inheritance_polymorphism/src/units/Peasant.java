package units;

public class Peasant extends Unit{


    public Peasant(String name) {
        super(name, 100, 5, "rake", 1);

    }
    @Override
    public String getInfo(){
        return String.format("Я, Крестьянин %s", this.getName());
    }
    @Override
    public String step(){
        return "Сделал шаг";
    }

}
