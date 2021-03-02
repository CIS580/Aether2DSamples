using System;

namespace tainicom.Aether.Physics2D.Samples.Testbed
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
}
