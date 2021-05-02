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
using FifaDatabase.SqlRepos.Reports;

namespace FifaDatabase.Views.ReportViews
{
    /// <summary>
    /// Interaction logic for HotHandView.xaml
    /// </summary>
    public partial class HotHandView : UserControl
    {
        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlHotHandRepository repo;
        //private TransactionScope transaction;

        public HotHandView()
        {
            InitializeComponent();
            repo = new SqlHotHandRepository(connectionString);
            Fill();

        }

        private void Fill()
        {
            try
            {
                PlayerDataGrid.ItemsSource = repo.RetrieveHotHands();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
