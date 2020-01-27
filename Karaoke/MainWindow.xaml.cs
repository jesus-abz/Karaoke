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

using NAudio.Wave;
using NAudio.Wave.SampleProviders;

using System.Windows.Threading;

namespace Karaoke
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;

        //lector de archivos
        AudioFileReader reader;
        //comunicacion con el equipo de audio
        WaveOut output;
        public MainWindow()
        {
            InitializeComponent();
            btnReproducir.IsEnabled = true;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Timer_Tick;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnReproducir.Visibility = Visibility.Hidden;
            prgBarraProgreso.Visibility = Visibility.Visible;
            txtLetra.Visibility = Visibility.Visible;

            reader = new AudioFileReader(@"5.mp3");
            output = new WaveOut();
            output.PlaybackStopped += Output_PlaybackStopped;
            output.Init(reader);
            output.Play();

            btnReproducir.IsEnabled = false;


            prgBarraProgreso.Maximum = reader.TotalTime.TotalSeconds;
            prgBarraProgreso.Value = reader.CurrentTime.TotalSeconds;

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            prgBarraProgreso.Value = reader.CurrentTime.TotalSeconds;

            if(prgBarraProgreso.Value > 1 && prgBarraProgreso.Value < 5)
            {
                txtLetra.Text = "lalala";
            }
            else if (prgBarraProgreso.Value > 5 && prgBarraProgreso.Value < 8)
            {
                txtLetra.Text = "lululu";
            }

        }
        private void Output_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            timer.Stop();
            reader.Dispose();
            output.Dispose();
        }

    }
}
