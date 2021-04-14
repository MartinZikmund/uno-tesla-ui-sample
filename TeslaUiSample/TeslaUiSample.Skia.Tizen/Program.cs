using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace TeslaUiSample.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new TeslaUiSample.App(), args);
            host.Run();
        }
    }
}
