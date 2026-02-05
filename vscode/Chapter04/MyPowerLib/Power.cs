namespace MyPowerLib;

public class Power
{
    // Calculates baseNum to the power of exponent
    public static double MyPow(double baseNum, double exponent)
    {
        return Math.Pow(baseNum, exponent);
    }

    // Calculates (baseNum^exp1)^exp2 [cite: 92]
    public static double MyPow(double baseNum, double exp1, double exp2)
    {
        double firstResult = Math.Pow(baseNum, exp1);
        return Math.Pow(firstResult, exp2);
    }
}