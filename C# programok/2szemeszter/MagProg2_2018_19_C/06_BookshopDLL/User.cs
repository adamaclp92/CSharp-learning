using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_BookshopDLL
{
    public class User
    {
        private static uint ID = 1;

        public User(string FirstName, string LastName, string Email,
            string Password)
        {
            this.Id = User.ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;

            //A user legyen sima felhasználó

            User.ID++;
        }
        public User(string FirstName, string LastName, string Email,
           string Password, Role Role)
            :this(FirstName, LastName, Email, Password)
        {
            this.Role = Role;
        }
        public User(string FirstName, string LastName, string Email,
           string Password, Role Role, Address Address)
            : this(FirstName, LastName, Email, Password, Role)
        {
            this.Address = Address;
        }


        public uint Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string email;
        public string Email
        {
            set
            {
                string regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                if (Regex.IsMatch(value, regex))
                    email = value;
                else throw new Exception("Invalid email!");
            }
            get
            {
                return email;
            }
        }      

        public string Password { get; set; }
        public Role Role { get; set; }
        public Address Address { get; set; }

        public void SendEmail(string subject, string message)
        {            
            MailMessage mail = new MailMessage();            
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("ede.troll@gmail.com");
            mail.To.Add(this.Email);
            mail.Subject = subject;
            mail.Body = message;

            SmtpServer.Port = 587;
            SmtpServer.Credentials =
                new NetworkCredential("ede.troll", "********");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
        public void SendHTMLEmail(string subject, string message)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("ede.troll@gmail.com");
            mail.To.Add(this.Email);
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = message;
            //mail.Attachments.Add(new Attachment("file elérési útja"));
            //mail.Attachments.Add(new Attachment("file elérési útja"));

            SmtpServer.Port = 587;
            SmtpServer.Credentials =
                new NetworkCredential("ede.troll", "********");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
