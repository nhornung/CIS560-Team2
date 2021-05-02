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
                    else if (Action == "Modify")
                    {
                        displayBorder.Child = new GameUpdate();
                    }
                    else if (Action == "Create")
                    {
                        displayBorder.Child = new GameCreate();
                    }
                    break;
                case "Locations":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new LocationSearch();
                    }

                    break;
                case "Managers":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new ManagerSearch();
                    }
                    else if (Action == "Modify")
                    {
                        displayBorder.Child = new ManagerUpdate();
                    }
                    else if (Action == "Create")
                    {
                        displayBorder.Child = new ManagerCreate();
                    }
                    break;
                case "Networks":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new NetworkSearch();
                    }

                    break;
                case "Players":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new PlayerSearch();
                    }
                    else if (Action == "Modify")
                    {
                        displayBorder.Child = new PlayerUpdate();
                    }
                    else if (Action == "Create")
                    {
                        displayBorder.Child = new PlayerCreate();
                    }
                    break;
                case "Stadiums":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new StadiumSearch();
                    }

                    break;
                case "Stats":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new StatsView();
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
                        break;//displayBorder.Child = new Tournam();
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

        private void CategoryCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(sender is ComboBox categoryCombo)
            {
                if (categoryCombo.SelectedIndex == 0 | categoryCombo.SelectedIndex == 2 | categoryCombo.SelectedIndex == 4)
                {
                    QueryTypeCombo.IsEnabled = true;
                }
                else
                {
                    QueryTypeCombo.IsEnabled = false;
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Border displayBorder = FindDisplayBorder();
            displayBorder.Child = new HotHandView();
        }
    }
}
