using FluentEmail.Core;
using FluentEmail.Razor;
using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WorkHive.Model;

namespace WorkHive.Controller
{
    public class MailNotif
    {
        public static async Task Send(string template, int id)
        {
            var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com", 587)
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("0323-2059@lspu.edu.ph", "Huskar@2002"),
                EnableSsl = true,

            });

            Email.DefaultSender = sender;
            Email.DefaultRenderer = new RazorRenderer();

            
            var member = MemberModelAccess.GetMemberInfo(id);

            var email = await Email
                .From("0323-2059@lspu.edu.ph", "noreply - WorkHive")
                .To(member.Email)
                .Subject("WorkHive Notif")
                .UsingTemplate(template.ToString(), member)
                .SendAsync();

        }
        private static string ResetPasswordTemplate(string oneTimeCodeString)
        {
            
            StringBuilder template = new StringBuilder();
            template.AppendLine("Dear @Model.FirstName,");
            template.AppendLine("<p> You are attempting to Reset your password </p>");
            template.AppendLine("<p> If this is not you, Discard this message </p>");
            template.AppendLine($"<h1> " + oneTimeCodeString + "</h1>");
            template.AppendLine(" - Workhive");

            

            return template.ToString();
        }
    }
}
