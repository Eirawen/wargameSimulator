using System;

public static class Utility {
    private static readonly Random random = new Random();

    public static int rollDice(int sides) {
        return random.Next(1, sides + 1);
    }

}
