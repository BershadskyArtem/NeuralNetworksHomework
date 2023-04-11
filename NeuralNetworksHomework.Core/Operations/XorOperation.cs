using NeuralNetworksHomework.Core.Activation;

namespace NeuralNetworksHomework.Core.Operations;

public class XorOperation : AbstractOperation
{
    public XorOperation() : base(new Neuron(
        new double[]{ 1,1 },
        -1,
        ActivationFuncsRepository.AbsoluteActivation
        ))
    {
    }

    public override double Run(double[] input)
    {
        var notOp = new NotOperation();
        return notOp.Run(new double[] { base.Run(input) });
    }
}