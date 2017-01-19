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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WPF_Timer.ViewModel;
using WPF_Timer.For_MVVM;

namespace WPF_Timer
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private int increment = 0;
        DispatcherTimer dt = new DispatcherTimer();
        private int time = 0;

        public UserControl1()
        {
            InitializeComponent();
            //Loaded += Window_Loaded;
        }

        private void Cycle_Time()
        {
            if (checkBox.IsChecked == true)
            {
                if (increment.ToString() == textBox.Text.ToString())
                {
                    increment = 0;
                    Timer_Label.Content = increment.ToString();
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new PersonViewModel();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += Dt_Tick;
            //dt.Start();
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            increment++;
            Timer_Label.Content = increment.ToString();
            Cycle_Time();
        }

        private void button_Click_Pause(object sender, RoutedEventArgs e)
        {
            time++;

            if ((time % 2) == 1)
            {
                dt.Start();
            }
            if ((time % 2) == 0)
            {
                dt.Stop();
            }
        }

        private void button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            increment = 0;
            Timer_Label.Content = increment.ToString();
            dt.Stop();
        }
    }
}

