﻿using QuanLyHocSinh.ViewModel.QuanLyTaiKhoan;
using QuanLyHocSinh.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace QuanLyHocSinh.View.Dialogs
{
    /// <summary>
    /// Interaction logic for ThemTaiKhoanDialog.xaml
    /// </summary>
    public partial class ThemTaiKhoanDialog : Window
    {

        // Sự kiện báo đã thêm tài khoản thành công, để ViewModel hoặc MainWindow bắt
        public event EventHandler AccountAddedSuccessfully;
        public ThemTaiKhoanDialog()
        {
            InitializeComponent();
        }
    }
}
