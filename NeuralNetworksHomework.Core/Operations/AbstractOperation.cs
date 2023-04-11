namespace NeuralNetworksHomework.Core.Operations;

public abstract class AbstractOperation
{
    protected readonly Neuron _neuron;

    protected AbstractOperation(Neuron neuron)
    {
        _neuron = neuron;
    }

    public virtual double Run(double[] input) => _neuron.Run(input);


}