using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Navigation;
using Application = System.Windows.Application;

namespace fitness_tracker
{
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FormsyxD xd = new FormsyxD();

            int calories = int.Parse(calories_add.Text);

            if (calories < 0)
            {
                System.Windows.MessageBox.Show("Calories cannot be negative");
            }
            else
            {
                xd.Form.calorie_text_info.TextMiddle += calories;
            }

        }
    }

    public class FormsyxD
    {
        public MainWindow Form = Application.Current.Windows[Application.Current.Windows.Count - 1] as MainWindow;
    }
}
