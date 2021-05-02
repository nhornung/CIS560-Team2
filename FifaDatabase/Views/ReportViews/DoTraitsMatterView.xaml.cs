using FifaDatabase.SqlRepos.Reports;
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

namespace FifaDatabase.Views.ReportViews
{
    /// <summary>
    /// Interaction logic for DoTraitsMatterView.xaml
    /// </summary>
    public partial class DoTraitsMatterView : UserControl
    {
        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlDoTraitsMatterRepository repo;
        //private TransactionScope transaction;

        public DoTraitsMatterView()
        {
            InitializeComponent();
            repo = new SqlDoTraitsMatterRepository(connectionString);
            Fill();

        }

        private void Fill()
        {
            try
            {
                PlayerDataGrid.ItemsSource = repo.RetrieveWinnerAVG();
                PlayerDataGrid_Copy.ItemsSource = repo.RetrieveLoserAVG();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
