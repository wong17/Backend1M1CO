using EstudiantesDesktopApp.Entities.Models;
using EstudiantesDesktopApp.Services;
using EstudiantesDesktopApp.Views;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace EstudiantesDesktopApp.Controllers
{
    public class MainWindowController
    {
        private readonly MainWindow _window;
        private readonly StudentService _studentService;
        private readonly List<Estudiante> _students;

        public MainWindowController(MainWindow window)
        {
            _window = window;
            _students = new List<Estudiante>();
            _studentService = new StudentService();
            InitController();
            ShowAllStudents();
        }

        private void InitController()
        {
            _window.NewBtn.Click += new RoutedEventHandler(MainWindowEventHandler);
            _window.EditBtn.Click += new RoutedEventHandler(MainWindowEventHandler);
            _window.DeleteBtn.Click += new RoutedEventHandler(MainWindowEventHandler);
            _window.ShowAllBtn.Click += new RoutedEventHandler(MainWindowEventHandler);
            _window.SearchByIDBtn.Click += new RoutedEventHandler(MainWindowEventHandler);
            _window.SearchTxt.PreviewTextInput += NumericOnlyTextBox_PreviewTextInput;
        }

        private void AddDataGridColumns()
        {
            var idColumn = new DataGridTextColumn
            {
                Header = "ID",
                Width = 30,
                Binding = new Binding("Id")
            };

            var nombreColumn = new DataGridTextColumn
            {
                Header = "Nombre",
                Width = 200,
                Binding = new Binding("Nombre")
            };

            var carnetColumn = new DataGridTextColumn
            {
                Header = "Carnet",
                Width = 100,
                Binding = new Binding("Carnet")
            };

            var carreraColumn = new DataGridTextColumn
            {
                Header = "Carrera",
                Width = 256,
                Binding = new Binding("Carrera")
            };

            _window.StudentsDataGrid.Columns.Add(idColumn);
            _window.StudentsDataGrid.Columns.Add(nombreColumn);
            _window.StudentsDataGrid.Columns.Add(carnetColumn);
            _window.StudentsDataGrid.Columns.Add(carreraColumn);
            _window.StudentsDataGrid.CanUserAddRows = false;
            if (_window.StudentsDataGrid.Items.Count > 0)
                _window.StudentsDataGrid.SelectedItem = _window.StudentsDataGrid.Items[0];
        }

        private void MainWindowEventHandler(object sender, RoutedEventArgs args)
        {
            Button Btn = (Button)sender;
            switch (Btn.Name)
            {
                case "NewBtn":
                    AddStudent();
                    break;

                case "EditBtn":
                    EditStudent();
                    break;

                case "DeleteBtn":
                    DeleteStudent();
                    break;

                case "ShowAllBtn":
                    ShowAllStudents();
                    break;

                case "SearchByIDBtn":
                    SearchStudent();
                    break;

                default:
                    break;
            }
        }

        private void NumericOnlyTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!IsNumeric(e.Text))
                e.Handled = true;
        }

        private static bool IsNumeric(string text)
        {
            return int.TryParse(text, out _);
        }

        private void AddStudent()
        {
            StudentEditorWindowController studentEditorWindow = new(this);
            studentEditorWindow.ShowDialog("Nuevo Estudiante");
        }

        private void EditStudent()
        {
            if (_window.StudentsDataGrid.SelectedItem is Estudiante e)
            {
                StudentEditorWindowController studentEditorWindow = new(this);
                studentEditorWindow.ShowDialog("Editar Estudiante", e.Id);
            }
        }

        private async void DeleteStudent()
        {
            if (_window.StudentsDataGrid.SelectedItem is Estudiante e)
            {
                var response = await _studentService.Delete(e.Id);
                if (response is not null && response.IsSuccess)
                {
                    MessageBox.Show("Estudiante eliminado exitosamente.", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                    ShowAllStudents();
                }
            }
        }

        private async void ShowAllStudents()
        {
            var response = await _studentService.Get();
            if (response is null)
                return;
            // Cargar datagrid con información de los Estudiantes
            if (_students.Count > 0)
            {
                _students.Clear();
                _window.StudentsDataGrid.ItemsSource = null;
                _window.StudentsDataGrid.Columns.Clear();
            }
            _students.AddRange(response);
            _window.StudentsDataGrid.CanUserAddRows = false;
            _window.StudentsDataGrid.ItemsSource = _students;
            AddDataGridColumns();
        }

        private async void SearchStudent()
        {
            if (string.IsNullOrWhiteSpace(_window.SearchTxt.Text) || _window.SearchTxt.Text.Contains(" "))
            {
                MessageBox.Show("ID debe ser un número positivo.", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var response = await _studentService.GetById(int.Parse(_window.SearchTxt.Text));
            if (response is null || response.Id == 0)
            {
                MessageBox.Show("No se encontro un Estudiante con el ingresado.", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            _students.Clear();
            _students.Add(response);
            _window.StudentsDataGrid.CanUserAddRows = false;
            _window.StudentsDataGrid.ItemsSource = null;
            _window.StudentsDataGrid.Columns.Clear();
            _window.StudentsDataGrid.ItemsSource = _students;
            AddDataGridColumns();
        }
    
        // Para actualizar tabla una vez se edita o registra un nuevo estudiante desde la ventana de editor
        public void RefreshDataGrid()
        {
            ShowAllStudents();
        }
    }
}