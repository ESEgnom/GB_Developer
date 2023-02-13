package units;

public class Rogue extends Unit{

    public Rogue(String name) {
        super(name, 120, 15, "knife", 3);
    }
    public String stab(Unit unit){
        String msg = "%s ударил ножем %s. %s";
        return String.format(msg, super.getName(), unit.getName(), super.makeDamage(unit));
    }
}
