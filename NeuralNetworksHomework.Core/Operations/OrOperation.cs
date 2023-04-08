using NeuralNetworksHomework.Core.Activation;

namespace NeuralNetworksHomework.Core.Operations;

public class OrOperation : AbstractOperation
{
    public OrOperation() : base(new Neuron(
        new double[]{1.0, 1.0},
            0.0,
            ActivationFuncsRepository.ThresholdZero
        ))
    {
    }
}