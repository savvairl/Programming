﻿using System.Windows;
using View.ViewModel;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();  
            MainVM mainvm = new MainVM();
            DataContext = mainvm;
        }
    }
}
