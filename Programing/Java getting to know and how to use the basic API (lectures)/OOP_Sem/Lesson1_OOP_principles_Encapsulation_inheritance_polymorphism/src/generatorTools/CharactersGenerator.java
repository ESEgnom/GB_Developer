package generatorTools;

import units.*;

import java.util.Random;

public class CharactersGenerator {
    public Unit characterSelection(NameGenerator ng){
        int characterId = 7;
        int val = new Random().nextInt(characterId);
        switch (val){
            case  1:
                return new Monk(ng.setName());
            case  2:
                return new Sniper(ng.setName());
            case  3:
                return new Peasant(ng.setName());
            case  4:
                return new Rogue(ng.setName());
            case  5:
                return new Crossbowman(ng.setName());
            case  6:
                return new Sorcerer(ng.setName());
            default:
                return new Spearman(ng.setName());

        }
    }
}
