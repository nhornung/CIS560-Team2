using FifaDatabase.SqlRepos.Reports;
using FifaDatabase.Models.Enums;

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
using FifaDatabase.SqlRepos;
using FifaDatabase.Models;
using System.Diagnostics;

namespace FifaDatabase.Views.ReportViews
{
    /// <summary>
    /// Interaction logic for ViewershipView.xaml
    /// </summary>
    public partial class ViewershipView : UserControl
    {
        const string connectionString = "Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True;";
        private SqlTvViewershipRepository repo;
        private SqlTeamRepository teamRepo;
        //private TransactionScope transaction;

        public ViewershipView()
        {
            InitializeComponent();
            repo = new SqlTvViewershipRepository(connectionString);
            var myEnum = StageEnums.Any;
            Combo.ItemsSource = myEnum.GetFriendlyNames();
            Combo.SelectedItem = myEnum.GetFriendlyName();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string stage = Combo.SelectedItem.ToString();
            if (stage == "Any")
            {
                stage = null;
            }
            DateTime? start = startDate.SelectedDate;
            DateTime? end = endDate.SelectedDate;

            dataGrid.ItemsSource = repo.GetViewershipByStageOrTeam(stage, start, end);
            Debug.WriteLine(dataGrid.ItemsSource);
            dataGrid.Visibility = Visibility.Visible;
        }
    }
}
