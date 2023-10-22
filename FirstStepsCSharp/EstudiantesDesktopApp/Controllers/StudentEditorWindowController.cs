using EstudiantesDesktopApp.Entities.Models;
using EstudiantesDesktopApp.Services;
using EstudiantesDesktopApp.Views;
using EstudiantesWebAPI.Common.Runtime;
using System;
using System.Windows;
using System.Windows.Controls;

namespace EstudiantesDesktopApp.Controllers
{
    public class StudentEditorWindowController
    {
        private readonly StudentEditorWindow _window;
        private readonly StudentService _studentService;
        private readonly MainWindowController _mainWindowController;
        private int? _studentId;

        public StudentEditorWindowController(MainWindowController mainWindowController)
        {
            _window = new StudentEditorWindow();
            _studentService = new StudentService();
            _mainWindowController = mainWindowController;
            InitController();
        }

        private void InitController()
        {
            _window.SaveBtn.Click += new RoutedEventHandler(StudentEditorWindowEventHandler);
            _window.Closed += StudentEditorWindowClosedEventHandler;
        }

        private void StudentEditorWindowEventHandler(object sender, RoutedEventArgs args)
        {
            Button Btn = (Button)sender;
            switch (Btn.Name)
            {
                case "SaveBtn":
                    SaveOrUpdate();
                    break;

                default:
                    break;
            }
        }

        private void StudentEditorWindowClosedEventHandler(object? sender, EventArgs args)
        {
            _mainWindowController.RefreshDataGrid();
        }

        public void ShowDialog(string title, int? id = null)
        {
            _window.HeaderTextLbl.Content = title;
            _studentId = id;
            if (_studentId.HasValue)
                LoadData();
            _window.IdTxt.IsReadOnly = true;
            _window.ShowDialog();
        }

        private async void LoadData()
        {
            if (!_studentId.HasValue)
            {
                MessageBox.Show("ID del Estudiante es obligatorio.", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                _window.Close();
                return;
            }
            // Buscar estudiante por ID
            var response = await _studentService.GetById(_studentId.Value);
            if (response is null || response.Id == 0)
            {
                MessageBox.Show("No se encontro un Estudiante con el ingresado.", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            _window.IdTxt.Text = response.Id.ToString();
            _window.NameTxt.Text = response.Nombre;
            _window.CarnetTxt.Text = response.Carnet;
            _window.CareerTxt.Text = response.Carrera;
        }

        private async void SaveOrUpdate()
        {
            if (string.IsNullOrWhiteSpace(_window.NameTxt.Text) || string.IsNullOrWhiteSpace(_window.CareerTxt.Text) || string.IsNullOrWhiteSpace(_window.CarnetTxt.Text))
            {
                MessageBox.Show("Atención todos los campos son obligatorios.", "Alert", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            // Obtener datos del estudiante de los campos de texto
            var student = new Estudiante()
            {
                Nombre = _window.NameTxt.Text,
                Carnet = _window.CarnetTxt.Text,
                Carrera = _window.CareerTxt.Text
            };
            APIResponse response;
            // Actualizar estudiante
            if (_studentId.HasValue)
            {
                student.Id = _studentId.Value;
                response = await _studentService.Update(student);
                if (!response.IsSuccess)
                {
                    MessageBox.Show(response.Message, "Alert", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            // Guardar nuevo estudiante
            else
            {
                response = await _studentService.Create(student);
                if (!response.IsSuccess)
                {
                    MessageBox.Show(response.Message, "Alert", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            // Mensaje de confirmación
            MessageBox.Show(response.Message, "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            _window.Close();
            return;
        }
    }
}