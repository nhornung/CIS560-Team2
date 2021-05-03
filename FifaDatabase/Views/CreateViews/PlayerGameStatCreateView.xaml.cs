using FifaDatabase.Models;
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

namespace FifaDatabase.Views.CreateViews
{
    /// <summary>
    /// Interaction logic for PlayerGameStatCreateView.xaml
    /// </summary>
    public partial class PlayerGameStatCreateView : UserControl
    {
        public PlayerGameStatCreateView()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.DataContext != null)
            {
                var playerModel = (PlayerModel)this.DataContext;
                var myEnum = StatsEnum.Goal;
                PositionBox.ItemsSource = myEnum.GetNiceNames();
                PositionBox.SelectedItem = myEnum.GetNiceName();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
