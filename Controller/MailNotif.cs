﻿using FluentEmail.Core;
using FluentEmail.Razor;
using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using WorkHive.Model;

namespace WorkHive.Controller
{
    public class MailNotif
    {
        private string _email;
        private string _template;
        private string[] elements;

        public enum Mailfunctions
        {
            ResetPassword

        }
        public MailNotif(string email, Mailfunctions function, string elements)
        {
            _email = email;
            switch (function)
            {
                case Mailfunctions.ResetPassword:
                    _template = ResetPasswordTemplate(elements);
                    
                    break;

            }
            Send(_email, _template);
        }

        private static async Task Send(string emailaddress, string template)
        {
            var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com", 587)
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("0323-2059@lspu.edu.ph", "Huskar@2002"),
                EnableSsl = true,

            });

            Email.DefaultSender = sender;
            Email.DefaultRenderer = new RazorRenderer();

            List<MemberModel> members = MemberModelAccess.GetMemberModel();

            var member = members.FirstOrDefault(m => m.Email == emailaddress);

            var email = await Email
                .From("0323-2059@lspu.edu.ph", "noreply - WorkHive")
                .To(emailaddress)
                .Subject("WorkHive Notif")
                .UsingTemplate(template, new { member.FirstName })
                .SendAsync();

        }
        public static string ResetPasswordTemplate(string oneTimeCodeString)
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
