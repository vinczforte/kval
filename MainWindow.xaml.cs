﻿using System;
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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static KvalEntities db = new KvalEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            if (myFrame.CanGoBack)
            {
                myFrame.GoBack();
            }
            else MessageBox.Show("Вы находитесь на главной странице");
        }
    }
}