using System.Net;
using System.Net.Mail;


namespace SystemDesign.Core.LoggingSystem;


public class SmtpEmailProvider : IEmailProvider
{
    private readonly string _smtpServer;
    private readonly int _smtpPort;
    private readonly string _smtpUsername;
    private readonly string _smtpPassword;

    public SmtpEmailProvider(string smtpServer, int smtpPort, string smtpUsername, string smtpPassword)
    {
        _smtpServer = smtpServer;
        _smtpPort = smtpPort;
        _smtpUsername = smtpUsername;
        _smtpPassword = smtpPassword;
    }

    public void Send(List<string> toRecipients, List<string> ccRecipients, string title, string body)
    {
        using (SmtpClient smtpClient = new SmtpClient(_smtpServer, _smtpPort))
        {
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword);
            smtpClient.EnableSsl = true;

            using (MailMessage mailMessage = new MailMessage())
            {
                foreach (string toRecipient in toRecipients)
                {
                    mailMessage.To.Add(toRecipient);
                }

                foreach (string ccRecipient in ccRecipients)
                {
                    mailMessage.CC.Add(ccRecipient);
                }

                mailMessage.Subject = title;
                mailMessage.Body = body;

                smtpClient.Send(mailMessage);
            }
        }
    }
}

