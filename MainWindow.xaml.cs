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

namespace u2BradleyTXTMSGreal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, RoutedEventArgs e)
        {
            if (txt_input.Text == "LOL")
            {
                txt_input.Text = txt_input.Text.Replace("LOL", "Laughing Out Loud");
            }

            if (txt_input.Text == "CU")

            {
                txt_input.Text = txt_input.Text.Replace("CU", "See You");
            }

            if (txt_input.Text == ":-)")
            {
                txt_input.Text = txt_input.Text.Replace(":-)", "Im Happy");
            }

            if (txt_input.Text == ":-(")
            {
                txt_input.Text = txt_input.Text.Replace(":-(", "Im Unhappy");
            }

            if (txt_input.Text == ";-)")
            {
                txt_input.Text = txt_input.Text.Replace(";-", "Wink");
            }

            if (txt_input.Text == ":-P")
            {
                txt_input.Text = txt_input.Text.Replace(":-P", "Stick Out Tongue");
            }

            if (txt_input.Text == "~.~")
            {
                txt_input.Text = txt_input.Text.Replace("~.~", "Sleppy");
            }

            if (txt_input.Text == "TA")
            {
                txt_input.Text = txt_input.Text.Replace("TA", "Totally Awesome");
            }

            if (txt_input.Text == "CCC")
            {
                txt_input.Text = txt_input.Text.Replace("CCC", "Canadian Computing Competition");
            }

            if (txt_input.Text == "CUZ")
            {
                txt_input.Text = txt_input.Text.Replace("CUZ", "Because");
            }

            if (txt_input.Text == "TY")
            {
                txt_input.Text = txt_input.Text.Replace("TY", "Thank You");
            }

            if (txt_input.Text == "YW")
            {
                txt_input.Text = txt_input.Text.Replace("YW", "Your Welcome");
            }

            if (txt_input.Text == "TTYL")
            {
                txt_input.Text = txt_input.Text.Replace("YW", "Talk To You Later Dude");
            }

        }
    }
}

