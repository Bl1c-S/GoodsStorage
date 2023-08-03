namespace ListParserTests;

[TestClass]
public class ParseToList
{

     public GoodsBase _goodsBase;
     public ListParser _listParser;

     public ParseToList()
     {
          _goodsBase = new GoodsBase();
          _listParser = new(_goodsBase.MinSnLength, _goodsBase.MaxSnLength);
     }

     [TestMethod]
     public void WhenListHave2str()
     {
          string lines = "first12321312\nsecond12321312\n";
          List<string> parsededList = new( _listParser.ParseToList(lines)!);

          Assert.IsTrue(parsededList.Count == 2);
          Assert.IsTrue(parsededList[0] == "first12321312");
          Assert.IsTrue(parsededList[1] == "second12321312");
     }
     [TestMethod]
     public void WhenListHave3str()
     {
          string lines = "first12321312\nsecond12321312\nthird12321312\n";
          List<string> parsededList = new(_listParser.ParseToList(lines)!);

          Assert.IsTrue(parsededList.Count == 3);
          Assert.IsTrue(parsededList[0] == "first12321312");
          Assert.IsTrue(parsededList[1] == "second12321312");
          Assert.IsTrue(parsededList[2] == "third12321312");
     }
     [TestMethod]
     public void WhenListHave1str()
     {
          string lines = "first12321312\n";
          List<string> parsededList = new(_listParser.ParseToList(lines)!);

          Assert.IsTrue(parsededList.Count == 1);
          Assert.IsTrue(parsededList[0] == "first12321312");
     }
     [TestMethod]
     public void WhenListHaveEmptyStr()
     {
          string lines = "";
          var list = _listParser.ParseToList(lines);

          Assert.IsTrue(list == null);
     }
     [TestMethod]
     public void WhenListHaveNull()
     {
          string lines = null!;
          var list = _listParser.ParseToList(lines);

          Assert.IsTrue(list == null);
     }
     [TestMethod]
     public void WhenListHave2str1empty()
     {
          string lines = "first12321312\n\nthird12321312\n";
          List<string> parsededList = new(_listParser.ParseToList(lines)!);

          Assert.IsTrue(parsededList.Count == 2);
          Assert.IsTrue(parsededList[0] == "first12321312");
          Assert.IsTrue(parsededList[1] == "third12321312");
     }

     [TestMethod]
     public void WhenListHave2str1Uncorect1() 
     {
          string lines = "first12321312\n\nthird12321312\n";
          List<string> parsededList = new(_listParser.ParseToList(lines)!);

          Assert.IsTrue(parsededList.Count == 2);
          Assert.IsTrue(parsededList[0] == "first12321312");
          Assert.IsTrue(parsededList[1] == "third12321312");
     }
     [TestMethod]
     public void WhenListHave2str1Uncorect2()
     {
          string lines = "first12321312\nфіі\nthird12321312\n12345678901234567890123456789012312345678901234567890123456789012\n";
          List<string> parsededList = new(_listParser.ParseToList(lines)!);

          Assert.IsTrue(parsededList.Count == 2);
          Assert.IsTrue(parsededList[0] == "first12321312");
          Assert.IsTrue(parsededList[1] == "third12321312");
     }
}
