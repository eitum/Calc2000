namespace ME_LabView
{
  public class Mathematics
  {
    public Status ResultStatus;

    #region Add-Function

    public byte Add(byte a, byte b)
    {
      if ((byte.MaxValue - a) < b)
      {
        ResultStatus = Status.overflow;
        return 0;
      }  
      else
      {
        ResultStatus = Status.successful;
        return (byte)(a + b);
      }
    }

    public ushort Add(ushort a, ushort b)
    {
      if ((ushort.MaxValue - a) < b)
      {
        ResultStatus = Status.overflow;
        return 0;
      }
      else
      {
        ResultStatus = Status.successful;
        return (ushort)(a + b);
      }
    }

    public uint Add(uint a, uint b)
    {
      if ((uint.MaxValue - a)< b)
      {
        ResultStatus = Status.overflow;
        return 0;
      }
      else
      {
        ResultStatus = Status.successful;
        return (uint)(a + b);
      }
    }

    public ulong Add(ulong a, ulong b)
    {
      if ((ulong.MaxValue - a) < b)
      {
        ResultStatus = Status.overflow;
        return 0;
      }
      else
      {
        ResultStatus = Status.successful;
        return (ulong)(a + b);
      }
    }

    public float Add(float a, float b)
    {
      if (a + b > float.MaxValue)
      {
        ResultStatus = Status.overflow;
        return 0;
      }
      else
      {
        ResultStatus = Status.successful;
        return (float)(a + b);
      }
    }

    public double Add(double a, double b)
    {
      if (a + b > double.MaxValue)
      {
        ResultStatus = Status.overflow;
        return 0;
      }
      else
      {
        ResultStatus = Status.successful;
        return (double)(a + b);
      }
    }

    #endregion
  }
}
