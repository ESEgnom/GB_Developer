package generatorTools;

import generatorTools.Name;

import java.util.Random;

public class NameGenerator {
    public String setName(){
        return String.valueOf(Name.values()[new Random().nextInt(Name.values().length - 1)]);
    }
}
