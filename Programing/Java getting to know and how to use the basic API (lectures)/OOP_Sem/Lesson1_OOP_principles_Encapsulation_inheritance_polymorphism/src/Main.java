import generatorTools.CharactersGenerator;
import generatorTools.Name;
import generatorTools.NameGenerator;
import generatorTools.TeamGanerator;
import units.*;

import java.util.ArrayList;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        NameGenerator ng = new NameGenerator();
        CharactersGenerator chg = new CharactersGenerator();
        TeamGanerator teamGen = new TeamGanerator();
        ArrayList<Unit> team = teamGen.generate(chg, ng);
        for (Unit unit: team) {
            System.out.println(unit.getInfo());
        }
    }






}