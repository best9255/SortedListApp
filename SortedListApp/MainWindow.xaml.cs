﻿using System;
using System.Collections;
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

namespace SortedListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedlist;
        public MainWindow()
        {
            InitializeComponent();
            sortedlist = new SortedList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            sortedlist.Add(int.Parse(keyTxt.Text), valueTxt.Text);
            ICollection collection = sortedlist.Keys;
            string data = string.Empty;
            foreach (int key in collection)
            {
                data +=$"{sortedlist[key]}\n";
            }
            MessageBox.Show(data);
        }
    }
}
