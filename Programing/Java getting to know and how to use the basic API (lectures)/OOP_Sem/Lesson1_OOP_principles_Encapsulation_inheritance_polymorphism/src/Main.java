import units.*;

public class Main {
    public static void main(String[] args) {
        Rogue rogueAlbert = new Rogue("Albert");
        Peasant peasantAlex = new Peasant("Alex");
        Sniper sniperGreg = new Sniper("Greg");
        Monk monkValentine = new Monk("Valentine");
        Sorcerer sorcererMerlin = new Sorcerer("Merlin");
        Spearman spearmanVelgelm = new Spearman("Velgelm");
        Crossbowman crossbowmanAdik = new Crossbowman("Adik");

        System.out.println(peasantAlex.getHitPoints());
        System.out.println(rogueAlbert.makeDamage(peasantAlex));
        System.out.println(peasantAlex.getHitPoints());
        System.out.println(sniperGreg.makeDamage(peasantAlex));
        System.out.println(peasantAlex.getHitPoints());
        System.out.println(monkValentine.treat(peasantAlex));
        System.out.println(peasantAlex.getHitPoints());
    }
}