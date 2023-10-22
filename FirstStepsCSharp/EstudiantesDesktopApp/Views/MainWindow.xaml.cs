﻿using EstudiantesDesktopApp.Controllers;
using System.Windows;

namespace EstudiantesDesktopApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _ = new MainWindowController(this);
        }
    }
}