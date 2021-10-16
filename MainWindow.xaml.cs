using System;
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

namespace TodoList
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (lstTodoList.Items.Contains(txtName.Text))
            {
                MessageBox.Show("Такая заметка уже существует!");
            }
            else if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                lstTodoList.Items.Add(txtName.Text);
                txtName.Clear();
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstTodoList.SelectedIndex >= 0)
            {
                lstTodoList.Items.Remove(lstTodoList.SelectedItem);
            }
        }
    }
}
