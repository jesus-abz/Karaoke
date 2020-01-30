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

            if (prgBarraProgreso.Value > 19 && prgBarraProgreso.Value < 22)
            {
                txtLetra.Text = "I know a bird";
            }
            else if (prgBarraProgreso.Value > 23 && prgBarraProgreso.Value < 27)
            {
                txtLetra.Text = "beautiful and absurd";
            }
            else if (prgBarraProgreso.Value > 29 && prgBarraProgreso.Value < 34)
            {
                txtLetra.Text = "haven't you heard";
            }
            else if (prgBarraProgreso.Value > 34 && prgBarraProgreso.Value < 36)
            {
                txtLetra.Text = "she's flying away";
            }
            else if (prgBarraProgreso.Value > 36 && prgBarraProgreso.Value < 38)
            {
                txtLetra.Text = "there's nothing to say";
            }
            else if (prgBarraProgreso.Value > 38 && prgBarraProgreso.Value < 47)
            {
                txtLetra.Text = "she's spreading her wings";
            }
            else if (prgBarraProgreso.Value > 48 && prgBarraProgreso.Value < 53)
            {
                txtLetra.Text = "at night when the world's asleep";
            }
            else if (prgBarraProgreso.Value > 54 && prgBarraProgreso.Value < (60 * 1) + 1)
            {
                txtLetra.Text = "hopeful for what the rising sun might bring";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 1 && prgBarraProgreso.Value < (60 * 1) + 3)
            {
                txtLetra.Text = "there's nothing to say";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 3 && prgBarraProgreso.Value < (60 * 1) + 5)
            {
                txtLetra.Text = "she's flying away";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 5 && prgBarraProgreso.Value < (60 * 1) + 8)
            {
                txtLetra.Text = "into the rising sun";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 9 && prgBarraProgreso.Value < (60 * 1) + 12)
            {
                txtLetra.Text = "a beautiful bird, unique and absurd";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 13 && prgBarraProgreso.Value < (60 * 1) + 16)
            {
                txtLetra.Text = "FIVE";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 17 && prgBarraProgreso.Value < (60 * 1) + 18)
            {
                txtLetra.Text = "touching the sun";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 18 && prgBarraProgreso.Value < (60 * 1) + 20)
            {
                txtLetra.Text = "out the barrel of a gun";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 20 && prgBarraProgreso.Value < (60 * 1) + 21)
            {
                txtLetra.Text = "is what everyone";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 22 && prgBarraProgreso.Value < (60 * 1) + 24)
            {
                txtLetra.Text = "dreams of before they're done";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 24 && prgBarraProgreso.Value < (60 * 1) + 25)
            {
                txtLetra.Text = "touching the sky";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 26 && prgBarraProgreso.Value < (60 * 1) + 27)
            {
                txtLetra.Text = "is what every guy";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 28 && prgBarraProgreso.Value < (60 * 1) + 29)
            {
                txtLetra.Text = "and girl ought to go try";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 30 && prgBarraProgreso.Value < (60 * 1) + 31)
            {
                txtLetra.Text = "just fly";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 32 && prgBarraProgreso.Value < (60 * 1) + 36)
            {
                txtLetra.Text = "and, even if you fall down and die";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 36 && prgBarraProgreso.Value < (60 * 1) + 37)
            {
                txtLetra.Text = "you'll make a big splash";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 38 && prgBarraProgreso.Value < (60 * 1) + 40)
            {
                txtLetra.Text = "or maybe you'll crash";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 40 && prgBarraProgreso.Value < (60 * 1) + 41)
            {
                txtLetra.Text = "into the sun";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 42 && prgBarraProgreso.Value < (60 * 1) + 46)
            {
                txtLetra.Text = "and turn into ash";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 46 && prgBarraProgreso.Value < (60 * 1) + 47)
            {
                txtLetra.Text = "there's nothing to say";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 47 && prgBarraProgreso.Value < (60 * 1) + 49)
            {
                txtLetra.Text = "she's flying away";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 50 && prgBarraProgreso.Value < (60 * 1) + 53)
            {
                txtLetra.Text = "into the rising sun";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 53 && prgBarraProgreso.Value < (60 * 1) + 55)
            {
                txtLetra.Text = "flying up there";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 55 && prgBarraProgreso.Value < (60 * 1) + 57)
            {
                txtLetra.Text = "does she even care?";
            }
            else if (prgBarraProgreso.Value > (60 * 1) + 57 && prgBarraProgreso.Value < (60 * 2) + 1)
            {
                txtLetra.Text = "out of sight out of mind";
            }
            else if (prgBarraProgreso.Value > (60 * 2) + 1 && prgBarraProgreso.Value < (60 * 2) + 3)
            {
                txtLetra.Text = "isn't it hard";
            }
            else if (prgBarraProgreso.Value > (60 * 2) + 3 && prgBarraProgreso.Value < (60 * 2) + 5)
            {
                txtLetra.Text = "flying so far";
            }
            else if (prgBarraProgreso.Value > (60 * 2) + 5 && prgBarraProgreso.Value < (60 * 2) + 8)
            {
                txtLetra.Text = "don't forget that you're loved";
            }
            else if (prgBarraProgreso.Value > (60 * 2) + 9 && prgBarraProgreso.Value < (60 * 2) + 10)
            {
                txtLetra.Text = "a beautiful bird";
            }
            else if (prgBarraProgreso.Value > (60 * 2) + 11 && prgBarraProgreso.Value < (60 * 2) + 12)
            {
                txtLetra.Text = "unique and absurd";
            }
            else if (prgBarraProgreso.Value > (60 * 2) + 13 && prgBarraProgreso.Value < (60 * 2) + 16)
            {
                txtLetra.Text = "FIVE";
            }
            else if (prgBarraProgreso.Value > (60 * 2) + 16 && prgBarraProgreso.Value < (60 * 2) + 20)
            {
                txtLetra.Text = " ";
            }
            else if (prgBarraProgreso.Value > (60 * 2) + 20 && prgBarraProgreso.Value < (60 * 2) + 42)
            {
                txtLetra.Text = "kuuhuu kuuhuu, Yeah, Yeah (x3)";
            }
            else if (prgBarraProgreso.Value > (60 * 2) + 43 && prgBarraProgreso.Value < (60 * 2) + 54)
            {
                txtLetra.Text = "kuuhuu kuuhuu, Yeah";
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
