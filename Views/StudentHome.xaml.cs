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
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf_exam.Views
{
    /// <summary>
    /// Interaction logic for StudentHome.xaml
    /// </summary>
    public partial class StudentHome : Window
    {
        public StudentHome()
        {
            InitializeComponent();
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            ChangeBorderColor((Border)sender, "#FFFFFF"); 
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            ChangeBorderColor((Border)sender, "#000000"); 
        }

        private void ChangeBorderColor(Border border, string hexColor)
        {
            Color color = (Color)ColorConverter.ConvertFromString(hexColor);
            var dropShadowEffect = (DropShadowEffect)border.Effect;
            dropShadowEffect.Color = color;
        }

        ///

        private void EnlargeBorder(Border border)
        {
            double widthIncrease = 6;
            double heightIncrease = 6;

            border.Width += widthIncrease;
            border.Height += heightIncrease;

            // Змінюємо положення бордера, щоб збільшення відбувалося з середини
            Thickness margin = border.Margin;
            margin.Left -= widthIncrease / 3;
            margin.Top -= heightIncrease / 3;
            border.Margin = margin;
        }

        private void BorderCart_MouseEnter(object sender, MouseEventArgs e)
        {
            EnlargeBorder((Border)sender);
        }

        private void BorderCard_MouseLeave(object sender, MouseEventArgs e)
        {
            // Якщо ви хочете зменшити розміри при виході з області
            Border border = (Border)sender;
            double widthDecrease = 6;
            double heightDecrease = 6;

            border.Width -= widthDecrease;
            border.Height -= heightDecrease;

            // Змінюємо положення бордера, щоб зменшення відбувалося до середини
            Thickness margin = border.Margin;
            margin.Left += widthDecrease / 3;
            margin.Top += heightDecrease / 3;
            border.Margin = margin;
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock clickedTextBlock = (TextBlock)sender;

            if (clickedTextBlock == secondTextBlock)
            {
                if (firstTextBlock.Text == "Домашні завдання")
                {
                    firstTextBlock.Text = "Лабораторні роботи";
                    secondTextBlock.Text = "Домашні";
                }
                else
                {
                    firstTextBlock.Text = "Домашні завдання";
                    secondTextBlock.Text = "Лабораторні";
                }
            }
            else { }
        }


        private void MenuBorder_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 80; // початкова ширина Border
            animation.To = 220; // нова ширина Border при наведенні
            animation.Duration = TimeSpan.FromSeconds(0.3);

            MenuBorder.BeginAnimation(Border.WidthProperty, animation);
        }

        private void MenuBorder_MouseLeave(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 220; // ширина Border при наведенні
            animation.To = 80; // початкова ширина Border
            animation.Duration = TimeSpan.FromSeconds(0.3);

            MenuBorder.BeginAnimation(Border.WidthProperty, animation);
        }

        private void AvatarBorder_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 70;
            animation.To = 100;
            animation.Duration = TimeSpan.FromSeconds(0.3);

            avatar.BeginAnimation(Border.WidthProperty, animation);
            avatar.BeginAnimation(Border.HeightProperty, animation);

            DoubleAnimation imageAnimation = new DoubleAnimation();
            imageAnimation.From = 70;
            imageAnimation.To = 100;
            imageAnimation.Duration = TimeSpan.FromSeconds(0.3);

            avatarImage.BeginAnimation(Image.WidthProperty, imageAnimation);
            avatarImage.BeginAnimation(Image.HeightProperty, imageAnimation);

            DoubleAnimation ellipseAnimation = new DoubleAnimation();
            ellipseAnimation.From = 35;
            ellipseAnimation.To = 90; 
            ellipseAnimation.Duration = TimeSpan.FromSeconds(0.3);

            ellipseGeometry.BeginAnimation(EllipseGeometry.RadiusXProperty, ellipseAnimation);
            ellipseGeometry.BeginAnimation(EllipseGeometry.RadiusYProperty, ellipseAnimation);
        }

        private void AvatarBorder_MouseLeave(object sender, MouseEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 100;
            animation.To = 70;
            animation.Duration = TimeSpan.FromSeconds(0.3);

            avatar.BeginAnimation(Border.WidthProperty, animation);
            avatar.BeginAnimation(Border.HeightProperty, animation);

            DoubleAnimation imageAnimation = new DoubleAnimation();
            imageAnimation.From = 100;
            imageAnimation.To = 70;
            imageAnimation.Duration = TimeSpan.FromSeconds(0.3);

            avatarImage.BeginAnimation(Image.WidthProperty, imageAnimation);
            avatarImage.BeginAnimation(Image.HeightProperty, imageAnimation);

            DoubleAnimation ellipseAnimation = new DoubleAnimation();
            ellipseAnimation.From = 90; 
            ellipseAnimation.To = 35;
            ellipseAnimation.Duration = TimeSpan.FromSeconds(0.3);

            ellipseGeometry.BeginAnimation(EllipseGeometry.RadiusXProperty, ellipseAnimation);
            ellipseGeometry.BeginAnimation(EllipseGeometry.RadiusYProperty, ellipseAnimation);
        }
        private void ExitBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();
        }
    }
}
