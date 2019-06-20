/* Project Name: Guru Fitness
   Purpose: A single form to add new members to the club
   Name:    Fayomi Augustine
   Course: Info5102 
   Date:    27/01/2016
   
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool exit = false;
        private bool validate = false;
        private int day;
        private string FirstName, Lastname, City, PostalCode, Address, Comment, Month, Years, Trainer, Experienced, CurrentDay, Billing_Info;
        private string Beginer, High_performance, BankAccount, Annual, Monthly, Province;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void radioButtonBeginner_Checked(object sender, RoutedEventArgs e)
        {

        }
        private int Day()
        {
         
            try
            {
                int year = (int)yrCombo.SelectedValue;
                int month = mntCmb.SelectedIndex + 1;
                if (month < 1 || year < 1)
                {
                    month = 1;
                    
                }
                 day = DateTime.DaysInMonth(year, month);

                for (int i = 1; i <= day; i++)
                {
                    dayCmb.Items.Add(i);
                }
            }
            catch
            {
                MessageBox.Show("Some error found");
            }
           return day;
            
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dayCmb.Items.Clear();
            Day();
          
        }
       

        private void GetValue()
        {
           FirstName = firstNameTxt.Text;

           Lastname = lastNameTxt.Text;
           City  = cityTxt.Text;
           PostalCode = postalCodeTxt.Text;
           Address = addressTxt.Text;
           Comment = commentTxt.Text;
           Province = provinceCmb.Text;
           Month = mntCmb.Text;
           Years = yrCombo.Text;
           Trainer = trainercmb.Text;
           Experienced = experienceRadio.IsChecked.Value ? (string)experienceRadio.Content :"";
           Beginer = beginerRadio.IsChecked.Value ? (string)beginerRadio.Content :"";
           High_performance = highPerformanceRadio.IsChecked.Value ? (string)highPerformanceRadio.Content :"";
           CurrentDay = dayCmb.Text;
           BankAccount = bankChk.IsChecked.Value ? (string)bankChk.Content :"";
           Annual = annualChk.IsChecked.Value ? (string)annualChk.Content :"";
           Monthly = mntChk.IsChecked.Value ? (string)mntChk.Content : "";
          
      }
        private void Validation()
        {
            System.ComponentModel.CancelEventArgs e = new System.ComponentModel.CancelEventArgs();
            string pattern = "^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$";
            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            GetValue();
            if (String.IsNullOrWhiteSpace(firstNameTxt.Text) ||
                    FirstName.Any(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Please enter your First Name");
                
                firstNameTxt.Focus();
                e.Cancel = true;
                
            }
            else if (String.IsNullOrWhiteSpace(Lastname) ||
                    Lastname.Any(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Please enter your Last Name");
                lastNameTxt.Focus();
                e.Cancel = true;
            }
            else if (String.IsNullOrWhiteSpace(Address))
            {
                MessageBox.Show("Please enter your Address");
                addressTxt.Focus();
                e.Cancel = true;
            }
            else if (String.IsNullOrWhiteSpace(City) ||
                    City.Any(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Please enter your City");
                cityTxt.Focus();
                e.Cancel = true;
            }
            else if ((String.IsNullOrWhiteSpace(PostalCode)) || (reg.IsMatch(PostalCode)) == false)
            {  
                MessageBox.Show("Please enter your Postal code");
                postalCodeTxt.Focus();
                e.Cancel = true;
            }
            else if (String.IsNullOrWhiteSpace(Month))
            {
                MessageBox.Show("Please select a month");
                mntCmb.Focus();
                e.Cancel = true;
            }
            else if (String.IsNullOrWhiteSpace(Years))
            {
                MessageBox.Show("Please select a Year");
                yrCombo.Focus();
                e.Cancel = true;
            }
            else if (String.IsNullOrWhiteSpace(CurrentDay))
            {
                MessageBox.Show("Please select a Day");
                dayCmb.Focus();
                e.Cancel = true;
            }
            else if (String.IsNullOrWhiteSpace(Province))
            {
                MessageBox.Show("Please select a Province");
                provinceCmb.Focus();
                e.Cancel = true;
            }
            else if (String.IsNullOrWhiteSpace(Trainer))
            {
                MessageBox.Show("Please select a Trainer");
                trainercmb.Focus();
                e.Cancel = true;
            }
            else if (String.IsNullOrEmpty(Experienced) && String.IsNullOrEmpty(Experienced) && String.IsNullOrEmpty(Beginer))
            {
                MessageBox.Show("Please select a Program Level");
                experienceRadio.Focus();
                e.Cancel = true;
            }
            else if (String.IsNullOrEmpty(BankAccount) && String.IsNullOrEmpty(Annual) && String.IsNullOrEmpty(Monthly))
            {
                MessageBox.Show("Please select a Billing Info");
                bankChk.Focus();
                e.Cancel = true;
            }
            else
            {
                validate = true;
            }
        }

        private void StringBuild()
        {
            GetValue();
            var newLine = Environment.NewLine;
            string customerInfo = "**********Fitness Guru Customer Information**********" + newLine + "First Name: " + FirstName + newLine +
                                  "Last Name:  " + Lastname + newLine +
                                  "DOB:  " + Years + " " + Month + " " + CurrentDay + newLine +
                                  "Address:  " + Address + newLine +
                                  "City: " + City + newLine +
                                  "Province: " + Province + newLine +
                                  "Postal Code: " + PostalCode + newLine +
                                  "Comments:  " + Comment + newLine +
                                  "Trainer: " + Trainer + newLine +
                                  "Program Level:  " + Experienced + High_performance + Beginer + newLine +
                                  "Billing Info: " + BankAccount + Annual + Monthly + newLine;

            System.IO.File.WriteAllText("NewMemeber.txt", customerInfo);

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }
        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            for (int yr = 1910; yr <= DateTime.UtcNow.Year; ++yr)
            {
                yrCombo.Items.Add(yr);
                yrCombo.SelectedIndex = 0;
               
             
            }
        }

        private void exitButton ()
        {
            string messageBoxText = "Do you want to exit without saving?";
            string caption = "Guru fitness";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;
            if (exit == false)
            {
                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
                this.Focus();
                if (result == MessageBoxResult.Yes)
                {
                    exit = true;
                    Application.Current.Shutdown();
                }
            }
        }
        private void dayCmb_SelectionChanged(object sender, EventArgs e)
        {
           
          
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            exitButton();
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            exitButton();
            e.Cancel = true;
           
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            if (validate == false)
            {
                Validation();
            }
            else
            {
                StringBuild();
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Warning;
                string messageBoxText = "Customer information saved, Do you want to register as a new user? ";
                string caption = "Guru fitness";



                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
                this.Focus();
                if (result == MessageBoxResult.Yes)
                {
                    dayCmb.Items.Clear();
                    mntCmb.Items.Clear();
                    firstNameTxt.Clear();
                    lastNameTxt.Clear();
                    addressTxt.Clear();
                    cityTxt.Clear();
                    commentTxt.Clear();
                    postalCodeTxt.Clear();
                    provinceCmb.Items.Clear();
                    trainercmb.Items.Clear();
                    beginerRadio.IsChecked = false;
                    experienceRadio.IsChecked = false;
                    highPerformanceRadio.IsChecked = false;
                    bankChk.IsChecked = false;
                    mntChk.IsChecked = false;
                    annualChk.IsChecked = false;
                }
                else
                {
                    exit = true;
                    Application.Current.Shutdown();
                }



            }
        }

       

    }
}
