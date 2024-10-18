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

namespace MessageBoxApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }

        private void confirmName_Click(object sender, RoutedEventArgs e)
        {
            string input = nameBox.Text;

            // Проверка на ввод без верхнего регистра
            if (string.IsNullOrEmpty(input) || input != input.ToLower())
            {
                MessageBox.Show("Неверный ввод! Пожалуйста, введите текст в нижнем регистре.",
                                "Ошибка ввода",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Ввод принят!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void nameSave_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
