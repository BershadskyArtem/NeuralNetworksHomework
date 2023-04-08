namespace NeuralNetworksHomework.Core;

public class Neuron
{
    private readonly double[] _weights;
    private readonly double _bias;
    private readonly Func<double, double> _activate;


    public Neuron(double[] weights, double bias, Func<double, double> activate)
    {
        _weights = weights;
        _bias = bias;
        _activate = activate;
    }

    private double DotProduct(double[] inputs)
    {
        if (inputs.Length != _weights.Length)
            throw new ArgumentOutOfRangeException("Inputs and weights lengths must be equal.");
        double result = 0;

        for (int i = 0; i < inputs.Length; i++)
        {
            result += _weights[i] * inputs[i];
        }
        return result;
    }

    private double Activate(double input) => _activate(input);

    public double Run(double[] input)
    {
        return Activate(DotProduct(input) + _bias);
    }
    
    
}