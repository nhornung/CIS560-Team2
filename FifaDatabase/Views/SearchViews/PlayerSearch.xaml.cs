﻿using FifaDatabase.Models;
using FifaDatabase.SqlRepos;
using System;
using System.Collections.Generic;
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
using System.Diagnostics;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace FifaDatabase.Views.SearchViews
{
    
    /// <summary>
    /// Interaction logic for Players.xaml
    /// </summary>
    public partial class PlayerSearch : UserControl
    {
        
        public PlayerSearch()
        {
            InitializeComponent();
            Fill();
        }

        private void Fill()
        {
            
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM WorldCupSchema.Players", conn);
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
            if (NameSearchTextBox.Text != "Search Player Name" && NameSearchTextBox.Text != "" && NameSearchTextBox.Text != null)
            {
                string[] words = NameSearchTextBox.Text.Split(' ');
                foreach( string word in words){
                    command += $" AND Name LIKE '%{word}%' ";
                }
            }
            if(PositionBox.SelectedItem != null)
            {
                command += $" AND Position = '{PositionBox.SelectedItem.ToString()}' ";
            }

            if (AgeDatePicker.SelectedDate != null)
            {
                command += $"AND Age > '{AgeDatePicker.SelectedDate.ToString()}' ";
            }
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=ROBS-LAPTOP\\SQLEXPRESS;Database=master; Trusted_Connection=True");
                SqlCommand cmd = new SqlCommand($"SELECT * FROM WorldCupSchema.Players WHERE Height <= {HeightSlider.Value.ToString()} AND Weight <= {WeightSlider.Value.ToString()}" + command, conn);
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


