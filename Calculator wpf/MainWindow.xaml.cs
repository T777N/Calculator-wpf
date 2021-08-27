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

namespace Calculator_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int mainNum = 0;
        int BigNum = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string content = (sender as Button).Content.ToString();
            Label.Content = Label.Content + content;
        }

        private void BtnTF_Click(object sender, RoutedEventArgs e)
        {
            if (Label.Content != "" && Label.Content != null )
            {
                double number = double.Parse((string)Label.Content);
                number *= -1;
                Label.Content = $"{number}";
            }
        }

        private void BtnN_Click(object sender, RoutedEventArgs e)
        {


            if (BigNum == 0)
            {

            Label.Content = $"{Label.Content}{'.'}";
            BigNum = 1;
            }

        }

        private void BtnSum_Click(object sender, RoutedEventArgs e)
        {
            if (Label.Content!=""&&Label.Content!=null&& Label2.Content != "" && Label2.Content != null)
            {
                BigNum = 0;
                double num1 = double.Parse((string)Label.Content);
            double num2 = double.Parse((string)Label2.Content);
            double sum = 0;
            if (mainNum == 1)
            {

            sum = num1 + num2;
            }
            else if (mainNum == 2)
            {
            sum = num2 - num1;

            }
            else if (mainNum == 3)
            {
            sum = num1 * num2;

            }
            else if (mainNum == 4)
            {
            sum = num2 / num1;

            }
            else
            {
                sum = double.Parse((string)Label.Content);
            }
            Label2.Content = "";
            Label.Content = $"{sum}";
            mainNum = 0;
            }
        }

        public void Formulas(int num)
        {
            double firstNum = 0;
            if (Label.Content != "" && mainNum == 0)
            {
                firstNum = double.Parse((string)Label.Content);
                Label.Content = "";
                Label2.Content = $"{firstNum}";
                if (num == 1)
                {
                    BigNum = 0;
                    mainNum = 1;
                }
                else if (num == 2)
                {
                    BigNum = 0;
                    mainNum = 2;
                }
                else if (num == 3)
                {
                    BigNum = 0;
                    mainNum = 3;
                }
                else if (num == 4)
                {
                    BigNum = 0;
                    mainNum = 4;
                }

            }
            else if (mainNum == 1 && Label2.Content != "")
            {
                if (Label.Content != "" && Label2.Content != "")
                {
                double num1 = double.Parse((string)Label.Content);
                double num2 = double.Parse((string)Label2.Content);
                double sum = num1 + num2;
                Label2.Content = $"{sum}";
                Label.Content = "";

                }
                
            }
            else if (mainNum == 2 && Label2.Content != "")
            {
                if (Label.Content != "" && Label2.Content != "")
                { 
                double num1 = double.Parse((string)Label.Content);
                double num2 = double.Parse((string)Label2.Content);
                double sum = num2 - num1;
                Label2.Content = $"{sum}";
                Label.Content = ""; 
                }
                
            }
            else if (mainNum == 3 && Label2.Content != "")
            {
                if (Label.Content != "" && Label2.Content != "")
                { 
                double num1 = double.Parse((string)Label.Content);
                double num2 = double.Parse((string)Label2.Content);
                double sum = num2 * num1;
                Label2.Content = $"{sum}";
                Label.Content = ""; 
                }
                
            }
            else if (mainNum == 4 && Label2.Content != "")
            {
                if (Label.Content != "" && Label2.Content != "")
                { 
                double num1 = double.Parse((string)Label.Content);
                double num2 = double.Parse((string)Label2.Content);
                double sum = num2 / num1;
                Label2.Content = $"{sum}";
                Label.Content = ""; 
                }
                
            }

        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            Formulas(1);
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            Formulas(2);
        }

        private void BtnVurma_Click(object sender, RoutedEventArgs e)
        {

            Formulas(3);
        }

        private void BtnBolme_Click(object sender, RoutedEventArgs e)
        {

            Formulas(4);
        }

        private void BtnDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            Label.Content = "";
            Label2.Content = ""; 
        }

        private void BtnKvadrat_Click(object sender, RoutedEventArgs e)
        {
            if (Label.Content != "")
            {
                double number2 = double.Parse((string)Label.Content);
                number2 *= number2;
                Label.Content = $"{number2}"; 
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (Label.Content != null&&Label.Content!="")
            {
                int count = 0;
                double notice = double.Parse((string)Label.Content);
                if (notice == (int)notice)
                {
                    notice = (int)notice / 10;
                }
                else if (notice != (int)notice)
                {
                    bool a = true;
                    while (a)
                    {
                        if (notice * 10 != (int)notice * 10)
                        {
                            notice *= 10;
                            ++count;
                        }
                        else
                        {
                            notice = (int)notice / 10;
                            for (int i = 0; i < count - 1; i++)
                            {
                                notice /= 10;
                            }
                            a = false;
                        }
                    }

                }
               
                Label.Content = $"{notice}"; 

            }
        }
    }

    }

