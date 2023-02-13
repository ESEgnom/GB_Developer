package units;

public abstract class Magician extends Unit{
    private int manaPoints;
    private int fullManaPoints;

    public Magician(String name, int hitPoints, int damageResistance, String weapon, int atack, int fullManaPoints) {
        super(name, hitPoints, damageResistance, weapon, atack);
        this.manaPoints = fullManaPoints;
    }

    public String treat(Unit unit){
        if (manaPoints == 0){
            return String.format("Не хватает маны %s", restoreMana());
        }else{
            String msg = "%s применил заклинание здоровья к %s, %s";
            return String.format(msg, this.getName(), unit.getName(), unit.restoreHealth(this));
        }
    }

    private String restoreMana(){
        if(manaPoints < fullManaPoints){
            manaPoints += super.getAtack();
            return String.format("%s восстанавливается ", this.getName());
        }else{
            return "Мана полная";
        }
    }

}
