using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace BusinessLogic
{
    public class EmailSending
    {

        const string fromPassword = "za12sb";
        const string subject = "Subject";
        
        

        public EmailSending()
        {
        }

        public void send_mail(Exception x)
        {
            MailAddress fromAddress = new MailAddress("laszlo.erno@gmail.com", "NOTRIX - E_cAfe");
            MailAddress toAddress = new MailAddress("laszlo.erno@gmail.com", "Administrator");
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = x.Data.ToString() + "+++ STACK:" + x.StackTrace.ToString()
            })
            {
                smtp.Send(message);
            }

        }

        public void send_mail(string msg)
        {
            MailAddress fromAddress = new MailAddress("laszlo.erno@gmail.com", "NOTRIX - E_cAfe");
            MailAddress toAddress = new MailAddress("laszlo.erno@gmail.com", "Administrator");
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = msg//x.Data.ToString() + "+++ STACK:" + x.StackTrace.ToString()
            })
            {
                smtp.Send(message);
            }

        }


    }

    





}
