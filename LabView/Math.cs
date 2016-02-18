namespace ME_LabView
{
  public class Math
    {
      public Status ResultStatus;

      public byte Add(byte a, byte b)
      {
        if(a+b > byte.MaxValue)
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
    }
}
