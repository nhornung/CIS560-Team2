using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace FifaDatabase.Views.UpdateViews
{
    /// <summary>
    /// Interaction logic for ManagerUpdate.xaml
    /// </summary>
    public partial class ManagerUpdate : UserControl
    {

        public ManagerUpdate()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Nationality.Text == "Nationality")
            {
                MessageBox.Show("Type a Nationality");
                return;
            }
            if (NameSearchTextBox.Text is null || NameSearchTextBox.Text == "" || NameSearchTextBox.Text == "Manager Name")
            {
                MessageBox.Show("Type a name");
                return;
            }
            if (Nationality_Copy1.Text == "Nationality")
            {
                MessageBox.Show("Type a Nationality");
                return;
            }
            if (NameSearchTextBox_Copy2.Text is null || NameSearchTextBox_Copy2.Text == "" || NameSearchTextBox_Copy2.Text == "Manager Name")
            {
                MessageBox.Show("Type a name");
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True");
                SqlCommand cmd = new SqlCommand("WorldCupSchema.UpdateManager", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param;

                param = cmd.Parameters.Add("@OldName", SqlDbType.NVarChar, 48);
                param.Value = NameSearchTextBox.Text;
                param = cmd.Parameters.Add("@OldNationality", SqlDbType.NVarChar, 48);
                param.Value = Nationality.Text;
                param = cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 48);
                param.Value = NameSearchTextBox_Copy2.Text;
                param = cmd.Parameters.Add("@Nationality", SqlDbType.NVarChar, 48);
                param.Value = Nationality_Copy1.Text;




                // Execute the command.

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show($"{ NameSearchTextBox.Text} updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
