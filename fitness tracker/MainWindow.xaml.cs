using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;


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
            var date = DateTime.Now;

            date_box.Text = $"{date.Hour}:{date.Minute}:{date.Second}";
        }
    }
}
