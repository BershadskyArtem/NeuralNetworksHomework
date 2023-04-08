namespace NeuralNetworksHomework.Core.Activation;

public static class ActivationFuncsRepository
{
    public static double HardMax(double input)
    {
        return Math.Max(0, input);
    }


    public static double AbsoluteActivation(double input)
    {
        return Math.Abs(input);
    }

    public static double ThresholdZero(double input)
    {
        return input > 0 ? 1 : 0;
    }
}