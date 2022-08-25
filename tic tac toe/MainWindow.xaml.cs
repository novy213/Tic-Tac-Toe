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

namespace tic_tac_toe
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[] a = new char[3];
        char[] b = new char[3];
        char[] c = new char[3];
        bool j = true;
        bool[] x = new bool[9];
        bool win = false;
        public MainWindow()
        {
            InitializeComponent();
            for(int i = 0; i <= 8; i++)
            {
                x[i] = false;
            }
        }
        public void check()
        {
            if (a[0] == 'x' && a[1] == 'x' && a[2] == 'x')
            {
                w.Text = "Player 1 wygrywa";
                win = true;
            }
            else if (b[0] == 'x' && b[1] == 'x' && b[2] == 'x')
            {
                w.Text = "Player 1 wygrywa";
                win = true;
            }
            else if (c[0] == 'x' && c[1] == 'x' && c[2] == 'x')
            {
                w.Text = "Player 1 wygrywa";
                win = true;
            }
            else if (a[0] == 'x' && b[1] == 'x' && c[2] == 'x')
            {
                w.Text = "Player 1 wygrywa";
                win = true;
            }
            else if (a[2] == 'x' && b[1] == 'x' && c[0] == 'x')
            {
                w.Text = "Player 1 wygrywa";
                win = true;
            }
            else if (a[0] == 'x' && b[0] == 'x' && c[0] == 'x')
            {
                w.Text = "Player 1 wygrywa";
                win = true;
            }
            else if (a[1] == 'x' && b[1] == 'x' && c[1] == 'x')
            {
                w.Text = "Player 1 wygrywa";
                win = true;
            }
            else if (a[2] == 'x' && b[2] == 'x' && c[2] == 'x')
            {
                w.Text = "Player 1 wygrywa";
                win = true;
            }
            if (a[0] == 'o' && a[1] == 'o' && a[2] == 'o')
            {
                w.Text = "Player 2 wygrywa";
                win = true;
            }
            else if (b[0] == 'o' && b[1] == 'o' && b[2] == 'o')
            {
                w.Text = "Player 2 wygrywa";
                win = true;
            }
            else if (c[0] == 'o' && c[1] == 'o' && c[2] == 'o')
            {
                w.Text = "Player 2 wygrywa";
                win = true;
            }
            else if (a[0] == 'o' && b[1] == 'o' && c[2] == 'o')
            {
                w.Text = "Player 2 wygrywa";
                win = true;
            }
            else if (a[2] == 'o' && b[1] == 'o' && c[0] == 'o')
            {
                w.Text = "Player 2 wygrywa";
                win = true;
            }
            else if (a[0] == 'o' && b[0] == 'o' && c[0] == 'o')
            {
                w.Text = "Player 2 wygrywa";
                win = true;
            }
            else if (a[1] == 'o' && b[1] == 'o' && c[1] == 'o')
            {
                w.Text = "Player 2 wygrywa";
                win = true;
            }
            else if (a[2] == 'o' && b[2] == 'o' && c[2] == 'o')
            {
                w.Text = "Player 2 wygrywa";
                win = true;
            }
            if (win==false) {
                if (x[0] == true && x[1] == true && x[2] == true &&
                    x[3] == true && x[4] == true && x[5] == true &&
                    x[6] == true && x[7] == true && x[8] == true)
                    {
                        win = true;
                        w.Text = "remis";
                    }
            }
        }

        private void c3_Click(object sender, RoutedEventArgs e)
        {
            if (win == false)
            {
                if (c3.Content != null)
                {
                    w1.Text = "Pole c3 jest zajęte";
                }
                else
                {
                    if (j)
                    {
                        w1.Text = "";
                        c[2] = 'x';
                        j = false;
                        c3.Content = 'x';
                        x[0] = true;
                    }
                    else
                    {
                        w1.Text = "";
                        c[2] = 'o';
                        j = true;
                        c3.Content = 'o';
                        x[0] = true;
                    }
                    check();
                }
            }
        }

        private void c2_Click(object sender, RoutedEventArgs e)
        {
            if (win == false)
            {
                if (c2.Content != null)
                {
                    w1.Text = "Pole c2 jest zajęte";
                }
                else
                {
                    if (j)
                    {
                        w1.Text = "";
                        c[1] = 'x';
                        j = false;
                        c2.Content = 'x'; x[1] = true;
                    }
                    else
                    {
                        w1.Text = "";
                        c[1] = 'o';
                        j = true; x[1] = true;
                        c2.Content = 'o';
                    }
                    check();
                }
            }
        }

        private void c1_Click(object sender, RoutedEventArgs e)
        {
            if (win == false)
            {
                if (c1.Content != null)
                {
                    w1.Text = "Pole c1 jest zajęte";
                }
                else
                {
                    if (j)
                    {
                        w1.Text = "";
                        c[0] = 'x';
                        j = false; x[2] = true;
                        c1.Content = 'x';
                    }
                    else
                    {
                        w1.Text = "";
                        c[0] = 'o';
                        j = true; x[2] = true;
                        c1.Content = 'o';
                    }
                    check();
                }
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (win == false)
            {
                if (b3.Content != null)
                {
                    w1.Text = "Pole b3 jest zajęte";
                }
                else
                {
                    if (j)
                    {
                        w1.Text = "";
                        b[2] = 'x';
                        j = false; x[3] = true;
                        b3.Content = 'x';
                    }
                    else
                    {
                        w1.Text = "";
                        b[2] = 'o';
                        j = true; x[3] = true;
                        b3.Content = 'o';
                    }
                    check();
                }
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (win == false)
            {
                if (b2.Content != null)
                {
                    w1.Text = "Pole b2 jest zajęte";
                }
                else
                {
                    if (j)
                    {
                        w1.Text = "";
                        b[1] = 'x';
                        j = false; x[4] = true;
                        b2.Content = 'x';
                    }
                    else
                    {
                        w1.Text = "";
                        b[1] = 'o'; x[4] = true;
                        j = true;
                        b2.Content = 'o';
                    }
                    check();
                }
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (win == false)
            {
                if (b1.Content != null)
                {
                    w1.Text = "Pole b1 jest zajęte";
                }
                else
                {
                    if (j)
                    {
                        w1.Text = "";
                        b[0] = 'x';
                        j = false; x[5] = true;
                        b1.Content = 'x';
                    }
                    else
                    {
                        w1.Text = "";
                        b[0] = 'o'; x[5] = true;
                        j = true;
                        b1.Content = 'o';
                    }
                    check();
                }
            }
        }

        private void a3_Click(object sender, RoutedEventArgs e)
        {
            if (win == false)
            {
                if (a3.Content != null)
                {
                    w1.Text = "Pole a3 jest zajęte";
                }
                else
                {
                    if (j)
                    {
                        w1.Text = "";
                        a[2] = 'x'; x[6] = true;
                        j = false;
                        a3.Content = 'x';
                    }
                    else
                    {
                        w1.Text = "";
                        a[2] = 'o';
                        j = true;
                        a3.Content = 'o'; x[6] = true;
                    }
                    check();
                }
            }
        }

        private void a2_Click(object sender, RoutedEventArgs e)
        {
            if (win == false)
            {
                if (a2.Content != null)
                {
                    w1.Text = "Pole a2 jest zajęte";
                }
                else
                {
                    if (j)
                    {
                        w1.Text = "";
                        a[1] = 'x';
                        j = false;
                        a2.Content = 'x'; x[7] = true;
                    }
                    else
                    {
                        w1.Text = "";
                        a[1] = 'o';
                        j = true; x[7] = true;
                        a2.Content = 'o';
                    }
                    check();
                }
            }
        }

        private void a1_Click(object sender, RoutedEventArgs e)
        {
            if (win == false)
            {
                if (a1.Content != null)
                {
                    w1.Text = "Pole a1 jest zajęte";
                }
                else
                {
                    if (j)
                    {
                        w1.Text = "";
                        a[0] = 'x'; x[8] = true;
                        j = false;
                        a1.Content = 'x';
                    }
                    else
                    {
                        w1.Text = "";
                        a[0] = 'o'; x[8] = true;
                        j = true;
                        a1.Content = 'o';
                    }
                    check();
                }
            }
        }

        private void res_Click(object sender, RoutedEventArgs e)
        {
            a[0] = ' '; 
            a[1] = ' '; 
            a[2] = ' '; 
            b[0] = ' '; 
            b[1] = ' '; 
            b[2] = ' '; 
            c[0] = ' '; 
            c[1] = ' '; 
            c[2] = ' ';
            a1.Content = null;
            a2.Content = null;
            a3.Content = null;
            b1.Content = null;
            b2.Content = null;
            b3.Content = null;
            c1.Content = null;
            c2.Content = null;
            c3.Content = null;
            w.Text = " ";
            w1.Text = " ";
            win = false;
            for (int i = 0; i<= 8; i++){
                x[i] = false;
            }
        }
    }
}
