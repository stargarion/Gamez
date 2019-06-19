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
using System.Windows.Shapes;

namespace WpfDemoSolution.Tic
{
    /// <summary>
    /// Interaction logic for Tictac.xaml
    /// </summary>
    public partial class Tictac : Window
    {
        bool p1;
        bool p2;
        char p1v = 'X';
        char p2v = 'O';
        int click = 0;
        int randomno;
        int ps;
        public Tictac()
        {
            InitializeComponent();
            this.p1 = true;
            this.p2 = false;
            textb.Text = " Turn:  Player 1";
        }

        private char Check()
        {
            char n1 = Convert.ToChar(fir.Content);
            char n2 = Convert.ToChar(sec.Content);
            char n3 = Convert.ToChar(thi.Content);
            char n4 = Convert.ToChar(fou.Content);
            char n5 = Convert.ToChar(fif.Content);
            char n6 = Convert.ToChar(six.Content);
            char n7 = Convert.ToChar(sev.Content);
            char n8 = Convert.ToChar(eig.Content);
            char n9 = Convert.ToChar(nin.Content);

            if ((n1.Equals(n2) && n2.Equals(n3) && n1.Equals(p1v)) || (n1.Equals(n4) && n4.Equals(n7) && n1.Equals(p1v)) || (n1.Equals(n5) && n5.Equals(n9) && n1.Equals(p1v)) || (n2.Equals(n5) && n5.Equals(n8) && n2.Equals(p1v)) || (n3.Equals(n6) && n6.Equals(n9) && n3.Equals(p1v)) || (n4.Equals(n5) && n5.Equals(n6) && n4.Equals(p1v)) || (n7.Equals(n8) && n8.Equals(n9) && n7.Equals(p1v)) || (n3.Equals(n5) && n5.Equals(n7) && n3.Equals(p1v)))
                return p1v;

            if ((n1.Equals(n2) && n2.Equals(n3) && n1.Equals(p2v)) || (n1.Equals(n4) && n4.Equals(n7) && n1.Equals(p2v)) || (n1.Equals(n5) && n5.Equals(n9) && n1.Equals(p2v)) || (n2.Equals(n5) && n5.Equals(n8) && n2.Equals(p2v)) || (n3.Equals(n6) && n6.Equals(n9) && n3.Equals(p2v)) || (n4.Equals(n5) && n5.Equals(n6) && n4.Equals(p2v)) || (n7.Equals(n8) && n8.Equals(n9) && n7.Equals(p2v)) || (n3.Equals(n5) && n5.Equals(n7) && n3.Equals(p2v)))
                return p2v;

            //if (n1.Equals(null) && n2.Equals(null) && n3.Equals(null) && n4.Equals(null) && n5.Equals(null) && n6.Equals(null) && n7.Equals(null) && n8.Equals(null) && n9.Equals(null))
            //    return 'N';
            //else
            //    return 'Q';


            return 'R';
        }

        public void auto_c()
        {
    
        }

        private int RanNo()
        {
            int t = new Random().Next();
            return t;
        }

        private void Fir_Click(object sender, RoutedEventArgs e)
        {

                if (fir.Content == null && this.p2 == true)
                {
                    fir.Foreground = Brushes.Red;
                    fir.Content = p2v;
                    this.p2 = false;
                    this.p1 = true;
                    textb.Text = " Turn:  Player 1";
                    this.click += 1;
                }
                else if (fir.Content == null && this.p1 == true)
                {
                    fir.Content = p1v;
                    this.p1 = false;
                    this.p2 = true;
                    textb.Text = " Turn:  Player 2";
                    this.click += 1;
                }
                else
                    MessageBox.Show("Choose another box");
                char ch = Check();
                if (ch.Equals(p1v))
                    MessageBox.Show("player one wins");
                else if (ch.Equals(p2v))
                    MessageBox.Show("player two wins");
            int no = RanNo();
            this.randomno = (no % (9 - this.click));

        }

        private void Sec_Click(object sender, RoutedEventArgs e)
        {
                if (sec.Content == null && this.p2 == true)
                {
                    sec.Foreground = Brushes.Red;
                    sec.Content = p2v;
                    this.p2 = false;
                    this.p1 = true;
                    textb.Text = " Turn:  Player 1";
                    this.click += 1;
                }
                else if (sec.Content == null && this.p1 == true)
                {
                    sec.Content = p1v;
                    this.p1 = false;
                    this.p2 = true;
                    textb.Text = " Turn:  Player 2";
                    this.click += 1;
                }
                else
                    MessageBox.Show("Choose another box");
                char ch = this.Check();
                if (ch.Equals(p1v))
                    MessageBox.Show("player one wins");
                else if (ch.Equals(p2v))
                    MessageBox.Show("player two wins");
            
            int no = RanNo();
            this.randomno = (no % (9 - this.click));

        }

        private void Thi_Click(object sender, RoutedEventArgs e)
        {

                if (thi.Content == null && this.p2 == true)
                {
                    thi.Foreground = Brushes.Red;
                    thi.Content = p2v;
                    this.p2 = false;
                    this.p1 = true;
                    textb.Text = " Turn:  Player 1";
                    this.click += 1;
                }
                else if (thi.Content == null && this.p1 == true)
                {
                    thi.Content = p1v;
                    this.p1 = false;
                    this.p2 = true;
                    textb.Text = " Turn:  Player 2";
                    this.click += 1;
                }
                else
                    MessageBox.Show("Choose another box");
                char ch = Check();
                if (ch.Equals(p1v))
                    MessageBox.Show("player one wins");
                else if (ch.Equals(p2v))
                    MessageBox.Show("player two wins");
            
            int no = RanNo();
            this.randomno = (no % (9 - this.click));

        }

        private void Fou_Click(object sender, RoutedEventArgs e)
        {

                if (fou.Content == null && this.p2 == true)
                {
                    fou.Foreground = Brushes.Red;
                    fou.Content = p2v;
                    this.p2 = false;
                    this.p1 = true;
                    textb.Text = " Turn:  Player 1";
                    this.click += 1;
                }
                else if (fou.Content == null && this.p1 == true)
                {
                    fou.Content = p1v;
                    this.p1 = false;
                    this.p2 = true;
                    textb.Text = " Turn:  Player 2";
                    this.click += 1;
                }
                else
                    MessageBox.Show("Choose another box");
                char ch = Check();
                if (ch.Equals(p1v))
                    MessageBox.Show("player one wins");
                else if (ch.Equals(p2v))
                    MessageBox.Show("player two wins");
            
            int no = RanNo();
            this.randomno = (no % (9 - this.click));

        }

        private void Fif_Click(object sender, RoutedEventArgs e)
        {

                if (fif.Content == null && this.p2 == true)
                {
                    fif.Foreground = Brushes.Red;
                    fif.Content = p2v;
                    this.p2 = false;
                    this.p1 = true;
                    textb.Text = " Turn:  Player 1";
                    this.click += 1;
                }
                else if (fif.Content == null && this.p1 == true)
                {
                    fif.Content = p1v;
                    this.p1 = false;
                    this.p2 = true;
                    textb.Text = " Turn:  Player 2";
                    this.click += 1;
                }
                else
                    MessageBox.Show("Choose another box");
                char ch = Check();
                if (ch.Equals(p1v))
                    MessageBox.Show("player one wins");
                else if (ch.Equals(p2v))
                    MessageBox.Show("player two wins");
            
            int no = RanNo();
            this.randomno = (no % (9 - this.click));

        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {

                if (six.Content == null && this.p2 == true)
                {
                    six.Foreground = Brushes.Red;
                    six.Content = p2v;
                    this.p2 = false;
                    this.p1 = true;
                    textb.Text = " Turn:  Player 1";
                    this.click += 1;
                }
                else if (six.Content == null && this.p1 == true)
                {
                    six.Content = p1v;
                    this.p1 = false;
                    this.p2 = true;
                    textb.Text = " Turn:  Player 2";
                    this.click += 1;
                }
                else
                    MessageBox.Show("Choose another box");
                char ch = Check();
                if (ch.Equals(p1v))
                    MessageBox.Show("player one wins");
                else if (ch.Equals(p2v))
                    MessageBox.Show("player two wins");
            
            int no = RanNo();
            this.randomno = (no % (9 - this.click));

        }

        private void Sev_Click(object sender, RoutedEventArgs e)
        {

                if (sev.Content == null && this.p2 == true)
                {
                    sev.Foreground = Brushes.Red;
                    sev.Content = p2v;
                    this.p2 = false;
                    this.p1 = true;
                    textb.Text = " Turn:  Player 1";
                    this.click += 1;
                }
                else if (sev.Content == null && this.p1 == true)
                {
                    sev.Content = p1v;
                    this.p1 = false;
                    this.p2 = true;
                    textb.Text = " Turn:  Player 2";
                    this.click += 1;
                }
                else
                    MessageBox.Show("Choose another box");
                char ch = Check();
                if (ch.Equals(p1v))
                    MessageBox.Show("player one wins");
                else if (ch.Equals(p2v))
                    MessageBox.Show("player two wins");
            
            int no = RanNo();
            this.randomno = (no % (9 - this.click));

        }

        private void Eig_Click(object sender, RoutedEventArgs e)
        {

                if (eig.Content == null && this.p2 == true)
                {
                    eig.Foreground = Brushes.Red;
                    eig.Content = p2v;
                    this.p2 = false;
                    this.p1 = true;
                    textb.Text = " Turn:  Player 1";
                    this.click += 1;
                }
                else if (eig.Content == null && this.p1 == true)
                {
                    eig.Content = p1v;
                    this.p1 = false;
                    this.p2 = true;
                    textb.Text = " Turn:  Player 2";
                    this.click += 1;
                }
                else
                    MessageBox.Show("Choose another box");
                char ch = Check();
                if (ch.Equals(p1v))
                    MessageBox.Show("player one wins");
                else if (ch.Equals(p2v))
                    MessageBox.Show("player two wins");
            
            int no = RanNo();
            this.randomno = (no % (9 - this.click));

        }

        private void Nin_Click(object sender, RoutedEventArgs e)
        {

                if (nin.Content == null && this.p2 == true)
                {
                    nin.Foreground = Brushes.Red;
                    nin.Content = p2v;
                    this.p2 = false;
                    this.p1 = true;
                    textb.Text = " Turn:  Player 1";
                    this.click += 1;
                }
                else if (nin.Content == null && this.p1 == true)
                {
                    nin.Content = p1v;
                    this.p1 = false;
                    this.p2 = true;
                    textb.Text = " Turn:  Player 2";
                    this.click += 1;
                }
                else
                    MessageBox.Show("Choose another box");
                char ch = Check();
                if (ch.Equals(p1v))
                    MessageBox.Show("player one wins");
                else if (ch.Equals(p2v))
                    MessageBox.Show("player two wins");
            
            int no = RanNo();
            this.randomno = (no % (9 - this.click));

        }

        private void Ref_Click(object sender, RoutedEventArgs e)
        {
            fir.Content = sec.Content = thi.Content = fou.Content = fif.Content = six.Content = sev.Content = eig.Content = nin.Content = null;
            this.p1 = true;
            this.p2 = false;
            textb.Text = " Turn:  Player 1";
            p1r.Text = null;
            p2r.Text = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.p1v = Convert.ToChar(p1r.Text);
            this.p2v = Convert.ToChar(p2r.Text);
  
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            p2r.Visibility = Visibility.Hidden;
            p2e.Visibility = Visibility.Hidden;
            next.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            p2r.Visibility = Visibility.Visible;
            p2e.Visibility = Visibility.Visible;
            next.Visibility = Visibility.Hidden;
            ps = 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int ctr= 0;
            if (randomno == 0)
            {
                Fir_Click(sender, e);
                ctr++;
            }
            else if (randomno == 1)
            {
                Sec_Click(sender, e);
                ctr++;
            }
            else if (randomno == 2)
            {
                Thi_Click(sender, e);
                ctr++;
            }
            else if (randomno == 3)
            {
                Fou_Click(sender, e);
                ctr++;
            }
            else if (randomno == 4)
            {
                Fif_Click(sender, e);
                ctr++;
            }
            else if (randomno == 5)
            {
                Six_Click(sender, e);
                ctr++;
            }
            else if (randomno == 6)
            {
                Sev_Click(sender, e);
                ctr++;
            }
            else if (randomno == 7)
            {
                Eig_Click(sender, e);
                ctr++;
            }
            else if (randomno == 8)
            {
                Nin_Click(sender, e);
                ctr++;
            }
        }
    }
}