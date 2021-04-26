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

                    }
                    else if (Action == "Create")
                    {

                    }
                    break;
                case "Locations":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new LocationSearch();
                    }
                    else if (Action == "Modify")
                    {

                    }
                    else if (Action == "Create")
                    {

                    }
                    break;
                case "Managers":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new ManagerSearch();
                    }
                    else if (Action == "Modify")
                    {

                    }
                    else if (Action == "Create")
                    {

                    }
                    break;
                case "Networks":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new NetworkSearch();
                    }
                    else if (Action == "Modify")
                    {

                    }
                    else if (Action == "Create")
                    {

                    }
                    break;
                case "Players":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new PlayerSearch();
                    }
                    else if (Action == "Modify")
                    {

                    }
                    else if (Action == "Create")
                    {

                    }
                    break;
                case "Stadiums":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new StadiumSearch();
                    }
                    else if (Action == "Modify")
                    {

                    }
                    else if (Action == "Create")
                    {

                    }
                    break;
                case "Stats":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new StatsView();
                    }
                    else if (Action == "Modify")
                    {

                    }
                    else if (Action == "Create")
                    {

                    }
                    break;
                case "Teams":
                    if (Action == "Search")
                    {
                        displayBorder.Child = new TeamSearch();
                    }
                    else if (Action == "Modify")
                    {

                    }
                    else if (Action == "Create")
                    {

                    }
                    break;
                case "Tournaments":
                    if (Action == "Search")
                    {
                        break;//displayBorder.Child = new Tournam();
                    }
                    else if (Action == "Modify")
                    {

                    }
                    else if (Action == "Create")
                    {

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
    }
}
