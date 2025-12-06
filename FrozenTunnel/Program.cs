namespace FrozenTunnel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FrozenTunnel frozenTunnel1 = new FrozenTunnel("I___I_I");
            IceMelter iceMelter1 = new IceMelter(frozenTunnel1);
            int melted1 = iceMelter1.Melt();
            TunnelPrinter.PrintTunnel(frozenTunnel1);
            Console.WriteLine($"Total: {melted1}");
            Console.WriteLine("-----------------------------");
            FrozenTunnel frozenTunnel2 = new FrozenTunnel("I__I__I");
            IceMelter iceMelter2 = new IceMelter(frozenTunnel2);
            int melted2 = iceMelter2.Melt();
            TunnelPrinter.PrintTunnel(frozenTunnel2);
            Console.WriteLine($"Total: {melted2}");
        }
    }
}
