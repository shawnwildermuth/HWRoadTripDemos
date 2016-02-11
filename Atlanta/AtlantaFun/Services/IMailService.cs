namespace AtlantaFun.Services
{
  public interface IMailService
  {
    void SendMail(string to, string from, string body);
  }
}