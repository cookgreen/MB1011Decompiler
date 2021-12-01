using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBDecompiler
{
    public enum MBGenerateStats
    {
        NotSupported,
        Error,
        Success
    }

    public class MBUtility
    {
        public static string GenerateTextIDFile(string inputFile, string outputFile, out MBGenerateStats stats)
        {
            stats = MBGenerateStats.Success;

            string fileName = Path.GetFileName(inputFile);
            switch(fileName)
            {
                case "troops.txt":
                    return generateTroopsIDFile(inputFile, outputFile);
                case "item_kinds1.txt":
                    return generateItemKindsIDFile(inputFile, outputFile);
                default:
                    stats = MBGenerateStats.NotSupported;
                    return null;
            }
        }

        private static string generateItemKindsIDFile(string inputFile, string outputFile)
        {
            MBItemReader itemReader = new MBItemReader(inputFile);
            return itemReader.GenerateIDFile(outputFile);
        }

        private static string generateTroopsIDFile(string inputFile, string outputFile)
        {
            MBTrooperReader trooperReader = new MBTrooperReader(inputFile);
            return trooperReader.GenerateIDFile(outputFile);
        }
    }
}
