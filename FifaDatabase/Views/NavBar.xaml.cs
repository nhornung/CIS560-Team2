using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using FifaDatabase.Views.SearchViews;
using FifaDatabase.Views.CreateViews;
using FifaDatabase.Views.UpdateViews;
using FifaDatabase.Views.ReportViews;

namespace FifaDatabase.Views
{
    /// <summary>
    /// Interaction logic for NavBar.xaml
    /// </summary>
    public partial class NavBar : UserControl
    {
        public NavBar()
        {
            InitializeComponent();
            QueryTypeCombo.SelectedIndex = 0;
            CategoryCombo.SelectedIndex = 0;
            QueryTypeCombo.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Winning.IsChecked = false;
            Traits.IsChecked = false;
            Views.IsChecked = false;
            Hot.IsChecked = false;
            string Category = CategoryCombo.SelectionBoxItem.ToString();
            string Action = QueryTypeCombo.SelectionBoxItem.ToString();
            Debug.Write(Category);
            Border displayBorder = FindDisplayBorder();

            switch (Category)
            {
                case "Games":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new GameSearch();
                    }
                    else if (Action == "Create")
                    {
                        displayBorder.Child = new GameCreate();
                    }
                    break;

                    break;
                case "Managers":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new ManagerSearch();
                    }
                    else if (Action == "Create")
                    {
                        displayBorder.Child = new ManagerCreate();
                    }
                    break;

                    break;
                case "Players":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new PlayerSearch();
                    }
                    else if (Action == "Create")
                    {
                        displayBorder.Child = new PlayerCreate();
                    }
                    break;
                case "Teams":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new TeamSearch();
                    }

                    break;
                case "Tournaments":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new TournamentSearch();
                    }

                    break;
            }
        }

        private Border FindDisplayBorder()
        {
            // Start climbing the tree from this node
            DependencyObject parent = this;
            do
            {
                // Get this node's parent
                parent = LogicalTreeHelper.GetParent(parent);
            }
            // Invariant: there is a parent element, and it is not a ListSwitcher 
            while (!(parent is null || parent is MainWindow));
            MainWindow main = (MainWindow)parent;
            Border displayBorder = (Border)main.DisplayBorder;
            return displayBorder;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Border displayBorder = FindDisplayBorder();
            displayBorder.Child = new HotHandView();
            
        }

        private void Traits_Checked(object sender, RoutedEventArgs e)
        {
            Border displayBorder = FindDisplayBorder();
            displayBorder.Child = new DoTraitsMatterView();
            
        }

        private void Views_Checked(object sender, RoutedEventArgs e)
        {
            Border displayBorder = FindDisplayBorder();
            displayBorder.Child = new ViewershipView();
        }

        private void Winning_Checked(object sender, RoutedEventArgs e)
        {
            Border displayBorder = FindDisplayBorder();
            displayBorder.Child = new WinningPercentageWithGoalsView();
        }
    }
}
