﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace ToDoWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TopBar_LeftButton_Down(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ExitBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lBox.ItemsSource = Class1.ToDo;
        }
        private void MinimizeBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void Add_Task_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Add_Task add_task = new Add_Task();
            add_task.ShowDialog();
        }
    }
}
