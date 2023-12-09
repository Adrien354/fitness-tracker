using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;


namespace fitness_tracker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

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

        Window1 popupWindow = new Window1();
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if(!popupWindow.IsActive)
            {
                popupWindow.Show();
            }
        }
    }
}
