using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTestOssLibrary.UnitTests
{
  [TestClass]
  public class MyClassTests
  {
    [DataTestMethod]
    [DataRow(-1, DisplayName = "Value -1")]
    [DataRow(0, DisplayName = "Value Zero")]
    [DataRow(1, DisplayName = "Value One")]
    [DataRow(10, DisplayName = "Value 10")]
    public void CtorTest(int value)
    {
      var my = new MyClass(value);
      Assert.AreEqual(value, my.Value);
    }
  }
}
