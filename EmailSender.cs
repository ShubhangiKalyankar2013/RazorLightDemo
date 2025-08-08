using System.Net.Mail;

namespace RazorLightDemo;
public class EmailSender
{
    private readonly string _smtpHost = "smtp.gmail.com"; // e.g., smtp.gmail.com
    private readonly int _smtpPort = 25;
    private readonly string _smtpUser = "shubhangikalyankar@tengroup.com";
    private readonly string _smtpPass = "";

    public void SendEmail(string toEmail, string subject, string htmlBody)
    {
        var message = new MailMessage();
        message.From = new MailAddress(_smtpUser, "Your App Name");
        message.To.Add(toEmail);
        message.Subject = subject;
        message.Body = htmlBody;
        message.IsBodyHtml = true;

        var client = new SmtpClient(_smtpHost, _smtpPort)
        {
            EnableSsl = true
        };

        client.Send(message);
    }
}
