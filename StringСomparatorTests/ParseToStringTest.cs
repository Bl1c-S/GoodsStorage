namespace StringСomparatorTests;

[TestClass]
public class ParseToStringTest
{
     private GoodsBase _goodsBase;
     private ListParser _listParser;
     public ParseToStringTest()
     {
          _goodsBase = new GoodsBase();
          _listParser = new(_goodsBase.MinSnLength, _goodsBase.MaxSnLength);
     }

     [TestMethod]
     public void WhenListHave2str()
     {
          List<string> list = new();
          list.Add("first");
          list.Add("second");

          string? parsededString = _listParser.ParseToString(list);

          Assert.IsTrue(parsededString == "first\nsecond\n");
     }
     [TestMethod]
     public void WhenListHave1str()
     {
          List<string> list = new();
          list.Add("first");

          string? parsededString = _listParser.ParseToString(list);

          Assert.IsTrue(parsededString == "first\n");
     }
     [TestMethod]
     public void WhenListHaveEmptyStr()
     {
          List<string> list = new();
          list.Add("");

          string? parsededString = _listParser.ParseToString(list);

          Assert.IsTrue(parsededString == null);
     }
     [TestMethod]
     public void WhenListHaveNull()
     {
          List<string> list = new();

          string? parsededString = _listParser.ParseToString(list);

          Assert.IsTrue(parsededString == null);
     }
     [TestMethod]
     public void WhenListHave2StrAnd1EmptyFirst()
     {
          List<string> list = new();
          list.Add("");
          list.Add("second");
          list.Add("third");

          string? parsededString = _listParser.ParseToString(list);

          Assert.IsTrue(parsededString == "second\nthird\n");
     }
     [TestMethod]
     public void WhenListHave2StrAnd1EmptySecond()
     {
          List<string> list = new();
          list.Add("first");
          list.Add("");
          list.Add("third");

          string? parsededString = _listParser.ParseToString(list);

          Assert.IsTrue(parsededString == "first\nthird\n");
     }
     [TestMethod]
     public void WhenListHave2StrAnd1EmptyThird()
     {
          List<string> list = new();
          list.Add("first");
          list.Add("second");
          list.Add("");

          string? parsededString = _listParser.ParseToString(list);

          Assert.IsTrue(parsededString == "first\nsecond\n");
     }
}