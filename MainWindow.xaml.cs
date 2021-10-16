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

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (lstTodoList.Items.Contains(txtName.Text))
            {
                string text = string.Format("Заметка \"{0}\" уже существует!", txtName.Text);

                MessageBox.Show(text);
            }
            else if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                lstTodoList.Items.Add(txtName.Text);
                txtName.Clear();
            } else
            {
                txtName.Clear();
            }
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstTodoList.SelectedIndex >= 0)
            {
                lstTodoList.Items.Remove(lstTodoList.SelectedItem);
            }
        }
    }
}
