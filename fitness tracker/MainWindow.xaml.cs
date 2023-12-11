using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Linq;
using System.IO;

namespace fitness_tracker
{
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty CaloriesProperty =
        DependencyProperty.Register("Calories", typeof(string), typeof(Window), new PropertyMetadata(null));

        public string Calories
        {
            get { return (string)GetValue(CaloriesProperty); }
            set { SetValue(CaloriesProperty, value); }
        }

        public static readonly DependencyProperty DateDayProperty =
        DependencyProperty.Register("DateDay", typeof(string), typeof(Window), new PropertyMetadata(null));

        public string DateDay
        {
            get { return (string)GetValue(DateDayProperty); }
            set { SetValue(DateDayProperty, value); }
        }

        public MainWindow()
        {
            InitializeComponent();
            Calories = "0";
            DateDay = DateTime.Now.ToString("dddd");


            if (!File.Exists("calories.txt")){
                File.Create("calories.txt");
                File.WriteAllText("calories.txt", DateTime.Now.ToString("dddd dd/MM/yy") + $"Calories:{Calories}kcal" + Environment.NewLine);
            }

            string calories_txt_file = File.ReadAllText("calories.txt");

            if (!calories_txt_file.Contains(DateTime.Now.ToString("dddd dd/MM/yy")))
            {
                File.AppendAllText("calories.txt", DateTime.Now.ToString($"dddd dd/MM/yy ") + $"Calories:{Calories}kcal" + Environment.NewLine);
                Calories = "0";
            }

            calories_txt_file = File.ReadAllText("calories.txt");

            Calories = calories_txt_file.Substring(calories_txt_file.IndexOf(":", 0) + 1, calories_txt_file.IndexOf("kcal", 0) - calories_txt_file.IndexOf(":", 0) - 1);


            GetDate();

            InitTimer();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetDate();
        }

        public void GetDate()
        {
            date_box.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public int count_windows_open
        {
            get;
            set;
        }
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            
            if (count_windows_open == 0)
            {
                Window1 popupWindow = new Window1();
                popupWindow.Show();
                count_windows_open++;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public class TextboxText
    {
        public string textdata { get; set; }
    }
}
