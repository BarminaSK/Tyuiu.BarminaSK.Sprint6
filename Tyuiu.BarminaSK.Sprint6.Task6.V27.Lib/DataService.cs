using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BarminaSK.Sprint6.Task6.V27.Lib
{
    public class DataService : ISprint6Task6V27
    {
        public string CollectTextFromFile(string path)
        {

            using (StreamReader reader = new StreamReader(path))
            {
                string text = File.ReadAllText(path);
                string result = "";

                MatchCollection matches = Regex.Matches(text, @"\b[A-Za-z]*[H][A-Za-z]*\b");

                foreach (Match match in matches)
                {
                    if (result != "") result += " ";
                    result += match.Value;
                }

                return result;
            }
        }
    }
}
