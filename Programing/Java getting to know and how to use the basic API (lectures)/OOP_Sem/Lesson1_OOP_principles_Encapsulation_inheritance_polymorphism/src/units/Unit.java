package units;

public abstract class Unit implements Info{
    private String name;
    private int atack;
    private int hitPoints;
    private int damageResistance;
    private String  weapon;
    private int fullHitPoints;

    public Unit(String name, int fullHitPoints, int damageResistance, String weapon, int atack) {
        this.name = name;
        this.fullHitPoints = fullHitPoints;
        this.hitPoints = this.fullHitPoints;
        this.damageResistance = damageResistance;
        this.weapon = weapon;
        this.atack = atack;
    }

    public String makeDamage(Unit unit) {
        unit.takeDamage(this);
        return String.format("%s наносит удар %s", name, unit.name);
    }

    private String takeDamage(Unit unit) {
        String msgLoseGHealth = "%s теряет %s едениц здоровья";
        String msgDeath = "%s погибает";
        this.hitPoints -= unit.getAtack();
        if (this.hitPoints == 0) {
            return String.format(msgDeath, this.name);
        } else {
            return String.format(msgLoseGHealth, this.name, unit.getAtack());
        }
    }

    public String restoreHealth(Unit unit){
        if(hitPoints < fullHitPoints){

            while(hitPoints != fullHitPoints){
                hitPoints += 1;

            }
            return String.format("%s восстанавливается ", this.name);
        }else{
            return "Здоровье полное";
        }

    }

    public int getAtack() {
        return atack;
    }

    public String getName() {
        return name;
    }

    public int getHitPoints() {
        return hitPoints;
    }
}
