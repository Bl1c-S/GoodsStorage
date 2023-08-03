using System.Text;

namespace StringСomparator;

public class ListParser
{
     private int _minSnLength;
     private int _maxSnLength;
     public ListParser(int minSnLength, int maxSnLength)
     {
          _minSnLength = minSnLength;
          _maxSnLength = maxSnLength;
     }

     public string? ParseToString(List<string> list)
     {
          if (list == null || list.Count == 0)
               return null;

          StringBuilder stringBuilder = new();

          for (int i = 0; i < list.Count; i++)
          {
               string line = list[i];

               if (string.IsNullOrEmpty(line))
                    continue;

               stringBuilder.Append(line + '\n');
          }

          string strResult = stringBuilder.ToString();

          if (!string.IsNullOrEmpty(strResult))
               return strResult;

          return null; // If all string in list is empty
     }
     public IEnumerable<string>? ParseToList(string lines)
     {
          if (string.IsNullOrEmpty(lines))
               return null;

          List<string> list = new(lines.Split('\n'));
          var snList = list.Where(x => x.Length >= _minSnLength && x.Length <= _maxSnLength);

          return snList;
     }
     public int Main(string s)
     {
          if (string.IsNullOrEmpty(s))
               return 0;

          switch (s)
          {
               default:
                    return 0;

               case "s":
                    return 1;

               case "b":
                    {
                         Console.WriteLine("Exemple line");
                         return 2;
                    }
          }
     }
     public int Main0(string s)
     {
          if (!string.IsNullOrEmpty(s))
          {
               switch (s)
               {
                    case "s":
                         {
                              return 1;
                         }
                    case "b":
                         Console.WriteLine("Exemple line");
                         return 2;

                    default:
                         {
                              return 0;
                         }
               }
          }
          return 0;
     }
}