using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Double result ,ans;
        String oper = "";
        bool oppclick;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnaction(object sender, RoutedEventArgs e)
        {
            if (txtfld.Text == "0" || oppclick)
            {
                txtfld.Text= "" ;
            }
            oppclick = false;
            Button btn = (Button)sender;
            txtfld.Text = txtfld.Text + btn.Content;
            
            
        }

        private void btnnum_Click(object sender, RoutedEventArgs e)
        {

        }
                

        

        private void btnequal(object sender, RoutedEventArgs e)
        {
            
            switch (oper)
            {
                case "+":
                    ans = result + Double.Parse(txtfld.Text);
                    txtfld.Text = ans.ToString();
                    // txtfld.Text = (result + Double.Parse(txtfld.Text)).ToString;
                    break;
                case "-":
                    ans = result - Double.Parse(txtfld.Text);
                    txtfld.Text = ans.ToString();
                    // txtfld.Text = (result + Double.Parse(txtfld.Text)).ToString;
                    break;
                case "*":
                    ans = result * Double.Parse(txtfld.Text);
                    txtfld.Text = ans.ToString();
                    // txtfld.Text = (result + Double.Parse(txtfld.Text)).ToString;
                    break;
                case "/":
                    ans = result / Double.Parse(txtfld.Text);
                    txtfld.Text = ans.ToString();
                    // txtfld.Text = (result + Double.Parse(txtfld.Text)).ToString;
                    break;
                default:
                    break;
                    oppclick = false;
            }
        }


        private void btnoperation(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            oper = (String) btn.Content;
            result = Double.Parse(txtfld.Text);
            lblvalue.Text = txtfld.Text + " " + oper;
            oppclick = true;
            

        }

        private void txtfld_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnnumon_Click(object sender, RoutedEventArgs e)
        {
            this.btnnumon.IsEnabled = false;
            txtfld.IsEnabled = true;
            equal.IsEnabled = true;
            _7.IsEnabled = true;
            _8.IsEnabled = true;
            _9.IsEnabled = true;
            _4.IsEnabled = true;
            _5.IsEnabled = true;
            _6.IsEnabled = true;
            _1.IsEnabled = true;
            _2.IsEnabled = true;
               _3.IsEnabled = true;
            _0.IsEnabled = true;
            point.IsEnabled = true;
            add.IsEnabled = true;
            sub.IsEnabled = true;
            div.IsEnabled = true;
            multi.IsEnabled = true;
            btnnumoff.IsEnabled = true;

        }

        private void btnnumof_Click(object sender, RoutedEventArgs e) 
        {
            this.btnnumoff.IsEnabled = false;
            txtfld.IsEnabled = false;
            equal.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _0.IsEnabled = false;
            point.IsEnabled = false;
            add.IsEnabled = false;
            sub.IsEnabled = false;
            div.IsEnabled = false;
            multi.IsEnabled = false;
            btnnumon.IsEnabled = true;
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            txtfld.Text ="0";
        }

        private void btncc_Click(object sender, RoutedEventArgs e)
        {
            txtfld.Text = "0";
            lblvalue.Text = "";
        }
    }
}
