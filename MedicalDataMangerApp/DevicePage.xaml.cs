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

namespace MedicalDataMangerApp
{
    /// <summary>
    /// Interaction logic for DevicePage.xaml
    /// </summary>
    public partial class DevicePage : Page
    {
        private DeviceViewModel _viewModel;

        public DevicePage()
        {
            InitializeComponent();
            _viewModel = new DeviceViewModel();
            this.DataContext = _viewModel;
        }

        private void ButtonAdd(object sender, RoutedEventArgs e)
        {
            var editWindow = new EditDeviceDialog();
            editWindow.ShowDialog();

        }
    }
}
