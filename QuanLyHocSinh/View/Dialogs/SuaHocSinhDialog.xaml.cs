using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Windows.Media;
using QuanLyHocSinh.Model.Entities;
using QuanLyHocSinh.ViewModel.TraCuu;

namespace QuanLyHocSinh.View.Dialogs
{
    public partial class SuaHocSinhDialog : Window
    {
        //Khởi tạo học sinh
        public SuaHocSinhDialog(HocSinh hocSinh)
        {
            InitializeComponent();
            var vm = new SuaHocSinhViewModel(hocSinh);
            vm.CloseDialog += (result) =>
            {
                this.DialogResult = result;
                this.Close();
            };
            DataContext = vm;
        }
        private void DatePicker_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is DatePicker datePicker)
            {
                var textBox = FindVisualChild<DatePickerTextBox>(datePicker);
                if (textBox != null)
                {
                    textBox.IsReadOnly = true;           // Không cho nhập
                    textBox.IsHitTestVisible = false;    // Không cho click chuột
                    textBox.Cursor = null;               // Không hiện con trỏ nhập
                }
            }
        }
        private static T? FindVisualChild<T>(DependencyObject parent) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is T typedChild)
                    return typedChild;

                var result = FindVisualChild<T>(child);
                if (result != null)
                    return result;
            }
            return null;
        }
    }
}
