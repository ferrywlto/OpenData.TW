using System;
using System.Threading.Tasks;

namespace Roads.TW
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length != 2) {
                throw new ArgumentException("Usage: <input file> <output file>");
            }

            await Converter.FromCsvToJson(args[0], args[1]);
        }
    }
}
