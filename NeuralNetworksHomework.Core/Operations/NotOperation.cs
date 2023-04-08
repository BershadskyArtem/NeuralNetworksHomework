using NeuralNetworksHomework.Core.Activation;

namespace NeuralNetworksHomework.Core.Operations;

public class NotOperation : AbstractOperation
{
    public NotOperation() : base(new Neuron(
        new double[]{1},
        -1,
        ActivationFuncsRepository.AbsoluteActivation
        ))
    {
    }
}