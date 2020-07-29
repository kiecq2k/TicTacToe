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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public bool isPlayer1Turn { get; set; }
        public int Counter { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            isPlayer1Turn = false;
            Counter = 0;
            ClearButtons();
        }

        private void ClearButtons()
        {
            btn_0_0.Content = string.Empty; btn_0_0.Background = Brushes.White;
            btn_0_1.Content = string.Empty; btn_0_1.Background = Brushes.White;
            btn_0_2.Content = string.Empty; btn_0_2.Background = Brushes.White;
            btn_1_0.Content = string.Empty; btn_1_0.Background = Brushes.White;
            btn_1_1.Content = string.Empty; btn_1_1.Background = Brushes.White;
            btn_1_2.Content = string.Empty; btn_1_2.Background = Brushes.White;
            btn_2_0.Content = string.Empty; btn_2_0.Background = Brushes.White;
            btn_2_1.Content = string.Empty; btn_2_1.Background = Brushes.White;
            btn_2_2.Content = string.Empty; btn_2_2.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            isPlayer1Turn ^= true;
            Counter++;

            if(Counter > 9)
            {
                NewGame();
                return;
            }

            var btn = sender as Button;
            btn.Content = (isPlayer1Turn) ? "O" : "X";

            if(CheckIfPlayerWon())
            {
                Counter = 9;

            }
        }

        private bool CheckIfPlayerWon()
        {
            if((btn_0_0.Content.ToString() != string.Empty) &&(btn_0_0.Content == btn_0_1.Content) && (btn_0_1.Content == btn_0_2.Content))
            {
                btn_0_0.Background = Brushes.Green;
                btn_0_1.Background = Brushes.Green;
                btn_0_2.Background = Brushes.Green;
                return true;
            }
            else if ((btn_1_0.Content.ToString() != string.Empty) && (btn_1_0.Content == btn_1_1.Content) && (btn_1_1.Content == btn_1_2.Content))
            {
                btn_1_0.Background = Brushes.Green;
                btn_1_1.Background = Brushes.Green;
                btn_1_2.Background = Brushes.Green;
                return true;
            }
            else if ((btn_2_0.Content.ToString() != string.Empty) && (btn_2_0.Content == btn_2_1.Content) && (btn_2_1.Content == btn_2_2.Content))
            {
                btn_2_0.Background = Brushes.Green;
                btn_2_1.Background = Brushes.Green;
                btn_2_2.Background = Brushes.Green;
                return true;
            }
            else if ((btn_0_0.Content.ToString() != string.Empty) && (btn_0_0.Content == btn_1_0.Content) && (btn_1_0.Content == btn_2_0.Content))
            {
                btn_0_0.Background = Brushes.Green;
                btn_1_0.Background = Brushes.Green;
                btn_2_0.Background = Brushes.Green;
                return true;
            }
            else if ((btn_0_1.Content.ToString() != string.Empty) && (btn_0_1.Content == btn_1_1.Content) && (btn_1_1.Content == btn_2_1.Content))
            {
                btn_0_1.Background = Brushes.Green;
                btn_1_1.Background = Brushes.Green;
                btn_2_1.Background = Brushes.Green;
                return true;
            }
            else if ((btn_0_2.Content.ToString() != string.Empty) && (btn_0_2.Content == btn_1_2.Content) && (btn_1_2.Content == btn_2_2.Content))
            {
                btn_0_2.Background = Brushes.Green;
                btn_1_2.Background = Brushes.Green;
                btn_2_2.Background = Brushes.Green;
                return true;
            }
            else if ((btn_0_0.Content.ToString() != string.Empty) && (btn_0_0.Content == btn_1_1.Content) && (btn_1_1.Content == btn_2_2.Content))
            {
                btn_0_0.Background = Brushes.Green;
                btn_1_1.Background = Brushes.Green;
                btn_2_2.Background = Brushes.Green;
                return true;
            }
            else if ((btn_0_2.Content.ToString() != string.Empty) && (btn_0_2.Content == btn_1_1.Content) && (btn_1_1.Content == btn_2_0.Content))
            {
                btn_0_2.Background = Brushes.Green;
                btn_1_1.Background = Brushes.Green;
                btn_2_0.Background = Brushes.Green;
                return true;
            }

            return false;
        }
    }
}
