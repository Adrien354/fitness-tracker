using System;
using System.ComponentModel;
using System.IO;
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

                        if (File.ReadAllText("D:/calories.txt").Contains(DateTime.Now.ToString("dddd dd/MM/yy")) && !File.ReadAllText("D:/calories.txt").Contains("Calories:")){
                            File.AppendAllText("D:/calories.txt", $" Calories:{(window as MainWindow).Calories}kcal");
                        }
                        else
                        {
                            File.WriteAllText("D:/calories.txt", DateTime.Now.ToString($"dddd dd/MM/yy ") + $"Calories:{(window as MainWindow).Calories}kcal" + Environment.NewLine);
                        }
                    }

                    (window as MainWindow).count_windows_open = 0;
                }
            }

            this.Close();
        }
    }
}
