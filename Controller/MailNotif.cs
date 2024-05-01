using FluentEmail.Core;
using FluentEmail.Razor;
using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WorkHive.Controller
{
    public class MailNotif
    {
        public static async Task Send()
        {
            var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com", 465)
            {
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Port = 465
            });

            Email.DefaultSender = sender;
            Email.DefaultRenderer = new RazorRenderer();


            StringBuilder template = new StringBuilder();
            template.AppendLine("Dear @Model.FirstName,");
            template.AppendLine("<p> Task has been added named : @Model.TaskID </p>");
            template.AppendLine(" - Workhive");

            var email = await Email
                .From("codingpat383@gmail.com")
                .To("sirpatrick121402@gmail.com")
                .Subject("WorkHive Notif")
                .UsingTemplate(template.ToString(), MemberModelAccess.GetMemberInfo(0))
                .SendAsync();

        }
    }
}
