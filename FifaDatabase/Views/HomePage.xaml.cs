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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FifaDatabase.Helper_Code.Common;
using FifaDatabase.Models;

namespace FifaDatabase.Views
{
    /// <summary>  
    /// Interaction logic for HomePage.xaml  
    /// </summary>  
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Initialization.  
                string name = this.txtName.Text;

                // Verification.  
                if (string.IsNullOrEmpty(name))
                {
                    // Display Message  
                    MessageBox.Show("This field can not be empty. Please Enter Full Name", "Fail", MessageBoxButton.OK, MessageBoxImage.Error);

                    // Info  
                    return;
                }

                // Save Info.  
               // WorldCupLogic.SelectAllFromPlayer(name);

                // Display Message  
                MessageBox.Show("You are Successfully! Registered", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                Console.Write(ex);

                // Display Message  
                MessageBox.Show(ex.ToString());
            }
        }
    }
}