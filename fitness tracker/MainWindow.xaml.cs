using System;
using System.Windows;
using System.Windows.Input;


namespace fitness_tracker
{
    public partial class MainWindow : Window
    {
        static float timer = 1;

        public MainWindow()
        {
            InitializeComponent();

            GetDate();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        public void GetDate()
        {
            date_box.Text = DateTime.Now.ToString();
        }
    }
}
