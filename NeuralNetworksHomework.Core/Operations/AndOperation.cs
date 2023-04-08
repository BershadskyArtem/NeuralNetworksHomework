using NeuralNetworksHomework.Core.Activation;

namespace NeuralNetworksHomework.Core.Operations;

public class AndOperation : AbstractOperation
{
    public AndOperation() : base(new Neuron(
        new double[]{1,1},
            -1,
        ActivationFuncsRepository.HardMax
        ))
    {
    }
}