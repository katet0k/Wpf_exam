using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wpf_exam.Services;
using Wpf_exam.Views.admin;

namespace Wpf_exam.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    /// 

    public class AuthenticationService
    {
        private static List<UserModel> users = new List<UserModel>
    {
        new UserModel { Username = "student1", Password = "student1pass", Role = "Student" },
        new UserModel { Username = "teacher1", Password = "teacher1pass", Role = "Teacher" },
        new UserModel { Username = "admin1", Password = "admin1pass", Role = "Admin" }
    };

        public static bool Authenticate(string username, string password)
        {
            return users.Any(user => user.Username == username && user.Password == password);
        }

        public static string GetUserRole(string username)
        {
            var user = users.FirstOrDefault(u => u.Username == username);
            return user?.Role;
        }

        private class UserModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }
    }

    public partial class Login : Window
    {
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            bool isAuthenticated = AuthenticationService.Authenticate(usernameTextBox.Text, passwordBox.Password);

            if (isAuthenticated)
            {
                string userRole = AuthenticationService.GetUserRole(usernameTextBox.Text);

                if (userRole == "Student")
                {
                    StudentHome studentHomeView = new StudentHome();
                    studentHomeView.Show();
                    this.Close();
                }
                else if (userRole == "Teacher")
                {
                    TeacherHome teacherHomeView = new TeacherHome();
                    teacherHomeView.Show();
                    this.Close();
                }
                else if (userRole == "Admin")
                {
                    AdminHome adminHomeView = new AdminHome();
                    adminHomeView.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Неправильний логін чи пароль. Спробуйте ще раз.");
            }
        }
    }
    }
