using JsonParser.Helper;
using JsonParser.Models;


namespace ReceiptScanParser
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<ResponseModel> ModelList = ParserHelper.GetJson();

            
            ModelList = ModelList.Skip(1).ToList();

            
            List<ResponseModel> SortedList = ModelList.OrderBy(o => o.boundingPoly.vertices[0].y).ToList();

            
            List<String> ParsedList = ParserHelper.ParseList(SortedList);

          
            int lineNumber = 1;
            using (TextWriter tw = new StreamWriter("..\\..\\..\\Output\\Output.txt"))
            {
                foreach (String s in ParsedList)
                {
                    tw.WriteLine(lineNumber + " | " + s);
                    lineNumber++;
                }
            }
        }
    }
}
