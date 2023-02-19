package generatorTools;

import units.Unit;

import java.util.ArrayList;

public class TeamGanerator {

    public ArrayList<Unit> generate(CharactersGenerator cg, NameGenerator ng){
        int count = 10;
        ArrayList<Unit> team = new ArrayList<>();
        for (int i = 0; i <= count; i++) {
            team.add(cg.characterSelection(ng));
        }
        return team;
    }
}
