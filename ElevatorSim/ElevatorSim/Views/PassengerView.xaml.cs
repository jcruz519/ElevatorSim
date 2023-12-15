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
using ElevatorSim.ViewModels;

namespace ElevatorSim.Views
{
    /// <summary>
    /// Interaction logic for PassengerView.xaml
    /// </summary>
    public partial class PassengerView : UserControl
    {
        public PassengerView()
        {
            InitializeComponent();
            this.DataContext = ElevatorViewModel.InitElevator;
        }
    }
}
