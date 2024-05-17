using MyCards.MessageBoxes;
using MyCards.Models;
using MyCards.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MyCards.ViewModels
{
    class UserViewModel : BaseViewModel
    {
        private UserRepository userRepository;
        private User myUser;
        public User MyUser { get { return myUser; } set { myUser = value; OnPropertyChanged(nameof(MyUser)); } }
       
        public UserViewModel()
        {
            userRepository = new UserRepository();
            if(App.currentUser is null)
            {
                MyUser = new User();
            }
            else
            {
                MyUser = App.currentUser;
            }
            
        }
        public void updateUser(string password)
        {
            if(password != "")
            {
                MyUser.Password = password;
            }
            try
            {
                userRepository.update(MyUser);
                new DefaultMessageBox("Die Änderung wurde gespeichert!").Show();
            }
            catch (Exception ex)
            {
                new DefaultMessageBox(ex.Message).Show();
            }

        }

        public void userLogin(string username, string password, Window loginWindow) 
        {
            if (username != "" && password != "")
            {
               User? user = userRepository.findByUserName(username, password);
                if (user == null)
                {
                    new DefaultMessageBox("Anmeldung wurde fehlgeschlagen!").Show();
                }
                else
                {
                    App.currentUser = user;
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    loginWindow.Close();
                }
            }
        }
        public void addUser(string password)
        {
            try
            {
                MyUser.Password = password;
                userRepository.Add(MyUser);
                new DefaultMessageBox("Registration ist erfolgreich!").ShowDialog();
            }
            catch (Exception ex)
            {
                new DefaultMessageBox(ex.Message).ShowDialog();
            }
        }
        public void removeUser() 
        {
            var messageBoxMitOptions = new MsgBoxWithOptions("Wens Sie ihr Konto löschen, werden Ihre Kategorien und Karteikarten gelöscht. Möchten Sie trotzdem weitermachen?");
            var result = messageBoxMitOptions.ShowDialog();
            if (result == true)
            {
                userRepository.delete(MyUser);
            }
        }
        public void lostPasswordResque(string email, string username)
        {
            var user = userRepository.findUserByEmailAndUsername(new User {Email = email, Username = username });
            if (user is not null)
            {
                try
                {
                    using (SmtpClient smtpClient = new SmtpClient("smtp.example.com"))
                    {
                        smtpClient.Port = 587; // SMTP-Port
                        smtpClient.Credentials = new NetworkCredential("your_email@example.com", "your_password");
                        smtpClient.EnableSsl = true; // Für verschlüsselte Verbindung

                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("your_email@example.com");
                        mail.To.Add("recipient@example.com");
                        mail.Subject = "Test Email";
                        mail.Body = "Hello, this is a test email.";

                        smtpClient.Send(mail);
                    }

                    MessageBox.Show("Email sent successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending email: " + ex.Message);
                }
            }
        }
    }
}
