using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtlantaFun.Services
{
  public class MailService : IMailService
  {
    public void SendMail(string to, string from, string body)
    {
      Console.WriteLine($"Sending Mail to {to}");
    }
  }
}
