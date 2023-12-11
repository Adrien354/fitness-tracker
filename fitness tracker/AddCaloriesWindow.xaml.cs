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
            int calories = int.Parse(calories_add.Text);

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    if (calories < 1)
                    {
                        System.Windows.MessageBox.Show("You can't add 0 or less calories");
                    }

                    int actual_calories = int.Parse((window as MainWindow).Calories);

                    calories += actual_calories;

                    if (calories > 15000)
                    {
                        System.Windows.MessageBox.Show("It's not possible to have that much calories in one day");
                    }
                    else
                    {
                            (window as MainWindow).Calories = calories.ToString();
                    }

                    (window as MainWindow).count_windows_open = 0;
                }
            }

            this.Close();
        }

        private void calories_add_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            calories_add.IsEnabled = calories_add.Text.Length > 0 ? true : false;
        }
    }
}
