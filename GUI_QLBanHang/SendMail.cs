using System;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class SendMail : Form
    {
        private string email;
        private string newpasss;

        public SendMail(string email, string newpasss)
        {
            InitializeComponent();
            this.email = email;
            this.newpasss = newpasss;
            SendMail1();
        }
        private string result = "";
        public string getResult { get { return result; } }
        private void SendMail_Load(object sender, EventArgs e)
        {
            Thread r = new Thread(() =>
            {
                SendMail1(); // Gọi phương thức SendMail1 từ trong luồng
            });
            r.IsBackground = true;
            r.Start();
        }

        public bool SendMail1()
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                NetworkCredential cred = new NetworkCredential("nexeker123@gmail.com", "edpb otwv zvlq jnpj");
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("nexeker123@gmail.com");
                mailMessage.To.Add(email);
                mailMessage.Subject = "You have used the forget password feature";
                mailMessage.Body = "New Password is " + newpasss;

                smtp.Credentials = cred;
                smtp.EnableSsl = true;

                smtp.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
