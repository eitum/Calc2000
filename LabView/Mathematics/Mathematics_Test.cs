using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ME_LabView
{
  [TestClass]
  public class Mathematics_test
  {
    private Mathematics TestClass = new Mathematics();
    private byte a;
    private byte b;

    [TestMethod]
    public void Add_Valid()
    {
      this.a = 10;
      this.b = 20;

      byte result = TestClass.Add(this.a, this.b);

      Assert.AreEqual(30, result);
      Assert.AreEqual(Status.successful, this.TestClass.ResultStatus);
    }

    [TestMethod]
    public void Add_InValid()
    {
      this.a = 254;
      this.b = 2;

      byte result = TestClass.Add(this.a, this.b);

      Assert.AreEqual(0, result);
      Assert.AreEqual(Status.overflow, this.TestClass.ResultStatus);
      
    }
  }

}
