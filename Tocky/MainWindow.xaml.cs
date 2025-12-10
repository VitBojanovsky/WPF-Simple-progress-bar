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

            int x = Convert.ToInt32(tb.Text);
            a = x / 2;
            tb2.Text = a.ToString() + "%";
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            int x = Convert.ToInt32(tb.Text);
            Bobek.Value = y;
            if (y==x)
            {
                timer.Stop();

            }
            y++;

        }
    }
}