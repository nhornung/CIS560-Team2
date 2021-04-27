using System;
using System.Collections.Generic;
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

namespace FifaDatabase.Views.SearchViews
{
    /// <summary>
    /// Interaction logic for ManagerSearch.xaml
    /// </summary>
    public partial class ManagerSearch : UserControl
    {
        public ManagerSearch()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM WorldCupSchema.Managers", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                PlayerDataGrid.ItemsSource = reader;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string command = "";
            if (NameSearchTextBox.Text != "Search Manager Name" && NameSearchTextBox.Text != "" && NameSearchTextBox.Text != null)
            {
                int count = 0;
                string[] words = NameSearchTextBox.Text.Split(' ');
                foreach (string word in words)
                {
                    count++;
                    if(count <= 1) command += $" Name LIKE '%{word}%' ";
                    else command += $" AND Name LIKE '%{word}%' ";
                }

                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True");
                    SqlCommand cmd = new SqlCommand($"SELECT * FROM WorldCupSchema.Managers WHERE " + command, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    PlayerDataGrid.ItemsSource = reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
         }
    }
}

