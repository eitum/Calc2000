using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ME_LabView
{
  [TestClass]
  public class Mathematics_test
  {
    private Mathematics TestClass = new Mathematics();

#region Add-Function

    [TestMethod]
    public void AddU8_Valid()
    {
      byte a = 10;
      byte b = 20;

      byte result = TestClass.Add(a, b);

      Assert.AreEqual(30, result);
      Assert.AreEqual(Status.successful, this.TestClass.ResultStatus);
    }

    [TestMethod]
    public void AddU8_InValid()
    {
      byte a = byte.MaxValue-1;
      byte b = 2;

      byte result = TestClass.Add(a, b);

      Assert.AreEqual(0, result);
      Assert.AreEqual(Status.overflow, this.TestClass.ResultStatus);     
    }

    [TestMethod]
    public void AddU16_Valid()
    {
      ushort a = byte.MaxValue;
      ushort b = 20;

      ushort result = TestClass.Add(a, b);

      Assert.AreEqual(275, result);
      Assert.AreEqual(Status.successful, this.TestClass.ResultStatus);
    }

    [TestMethod]
    public void AddU16_InValid()
    {
      ushort a = ushort.MaxValue-1;
      ushort b = 4;

      ushort result = TestClass.Add(a, b);

      Assert.AreEqual(0, result);
      Assert.AreEqual(Status.overflow, this.TestClass.ResultStatus);
    }

    [TestMethod]
    public void AddU32_Valid()
    {
      uint a = ushort.MaxValue;
      uint b = 20;

      uint result = TestClass.Add(a, b);

      Assert.AreEqual((uint)65555, result);
      Assert.AreEqual(Status.successful, this.TestClass.ResultStatus);
    }

    [TestMethod]
    public void AddU32_InValid()
    {
      uint a = uint.MaxValue-1;
      uint b = 4;

      uint result = TestClass.Add(a, b);

      Assert.AreEqual((uint)0, result);
      Assert.AreEqual(Status.overflow, this.TestClass.ResultStatus);
    }

    [TestMethod]
    public void AddU64_Valid()
    {
      ulong a = uint.MaxValue;
      ulong b = 20;

      ulong result = TestClass.Add(a, b);

      Assert.AreEqual((ulong)4294967315, result);
      Assert.AreEqual(Status.successful, this.TestClass.ResultStatus);
    }

    [TestMethod]
    public void AddU64_InValid()
    {
      ulong a = ulong.MaxValue-1;
      ulong b = 4;

      ulong result = TestClass.Add(a, b);

      Assert.AreEqual((ulong)0, result);
      Assert.AreEqual(Status.overflow, this.TestClass.ResultStatus);
    }

    #endregion
  }
}
