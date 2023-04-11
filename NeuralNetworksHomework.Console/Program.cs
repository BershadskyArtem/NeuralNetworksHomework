using NeuralNetworksHomework.Core.Operations;

Console.WriteLine("Aot");

var orOp = new OrOperation();

Console.WriteLine("Or");
for (int x1 = 0; x1 < 2; x1++)
{
    for (int x2 = 0; x2 < 2; x2++)
    {
        var orOpResult = orOp.Run(new double[] { x1, x2 });
        Console.Write($"{x1} | {x2} | {orOpResult}");
        Console.WriteLine();
    }
}

Console.WriteLine();
var notOp = new NotOperation();
Console.WriteLine("Not");
for (int x1 = 0; x1 < 2; x1++)
{
    var notOpResult = notOp.Run(new double[] { x1 });
    Console.Write($"{x1} | {notOpResult}");
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine("Xor");
var xorOp = new XorOperation();

for (int x1 = 0; x1 < 2; x1++)
{
    for (int x2 = 0; x2 < 2; x2++)
    {
        var xorOpResult = xorOp.Run(new double[] { x1, x2 });
        Console.Write($"{x1} | {x2} | {xorOpResult}");
        Console.WriteLine();
    }
}


for (int i = 0; i < 1000; i++)
{
    int i1 = Random.Shared.Next(0,2) ;
    int i2 = Random.Shared.Next(0,2);
    var xorOpResult = xorOp.Run(new double[] { i1, i2 });
    Console.WriteLine($"{i1} | {i2} | {xorOpResult}");
}




Console.WriteLine();
var andOp = new AndOperation();
Console.WriteLine("And");

for (int x1 = 0; x1 < 2; x1++)
{
    for (int x2 = 0; x2 < 2; x2++)
    {
        var andOpResult = andOp.Run(new double[] { x1, x2 });
        Console.Write($"{x1} | {x2} | {andOpResult}");
        Console.WriteLine();
    }
}