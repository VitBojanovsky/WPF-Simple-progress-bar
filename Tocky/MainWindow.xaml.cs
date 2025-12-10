using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
namespace Tocky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public bool stop = false;
        public int x = 0;
        int a = 0;
        int y = 0;
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Tick += Timer_Tick;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            x = Convert.ToInt32(tb.Text);

            a = x / 2;
            if (a < 0)
            {
                a = a * -1;
            }
            tb2.Text = a.ToString() + "%";
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (stop == false)
            {
                if (x < 0)
                {
                    x = x * -1;
                }

                if (x > y)
                {
                    Bobek.Value = y;
                    if (y == x)
                    {
                        timer.Stop();

                    }
                    y++;
                }
                if (x < y)
                {
                    Bobek.Value = y;
                    if (y == x * -1 || y == 0)
                    {
                        timer.Stop();
                    }
                    y--;



                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (stopka.Content == "Stop")
            {
                stop = true;
                stopka.Content = "Start";

            }
            else
            {
                stop = false;
                stopka.Content = "Stop";
            }
        }
    }
}