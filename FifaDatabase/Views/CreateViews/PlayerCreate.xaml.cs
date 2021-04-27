using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FifaDatabase.SqlRepos;

namespace FifaDatabase.Views
{
    /// <summary>
    /// Interaction logic for PlayerCreate.xaml
    /// </summary>
    public partial class PlayerCreate : UserControl
    {
       
        public PlayerCreate()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (AgeDatePicker.SelectedDate is null)
            {
                MessageBox.Show("Pick a date!");
                return;
            }
            if (PositionBox.SelectedItem is null)
            {
                MessageBox.Show("Pick a position");
                return;
            }
            if (NameTextBox.Text is null)
            {
                MessageBox.Show("The name cannot be empty");
                return;
            }
            if (NameTextBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("The name contain numbers");
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True");
                SqlCommand cmd = new SqlCommand("WorldCupSchema.CreatePlayer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter param;

                param = cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 48);
                param.Value = NameTextBox.Text;
                param = cmd.Parameters.Add("@Age", SqlDbType.Date);
                param.Value = AgeDatePicker.SelectedDate;
                param = cmd.Parameters.Add("@Position", SqlDbType.NVarChar, 12);
                param.Value = PositionBox.SelectedItem.ToString();
                param = cmd.Parameters.Add("@Height", SqlDbType.Int);
                param.Value = HeightSlider.Value;
                param = cmd.Parameters.Add("@Weight", SqlDbType.Int);
                param.Value = WeightSlider.Value;



                // Execute the command.

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show($"{ NameTextBox.Text} added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
