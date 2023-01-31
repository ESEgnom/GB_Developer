package test;

import App.Solution;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
    @org.junit.jupiter.api.Test
    void countPathsOne() {
        assertEquals(3432, Solution.countPaths(8, 8, 0, 0));
    }

    @org.junit.jupiter.api.Test
    void countPathsTwo() {
        assertEquals(6, Solution.countPaths(3, 3, 0, 0));
    }

    @org.junit.jupiter.api.Test
    void countPathsThree() {
        assertEquals(120, Solution.countPaths(4, 8, 0, 0));
    }

    @org.junit.jupiter.api.Test
    void countPathsFour() {
        assertEquals(70, Solution.countPaths(5, 5, 0, 0));
    }

    @org.junit.jupiter.api.Test
    void countPathsFive() {
        assertEquals(92378, Solution.countPaths(10, 11, 0, 0));
    }
}
