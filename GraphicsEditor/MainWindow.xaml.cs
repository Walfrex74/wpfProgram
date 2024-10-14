using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Ink;
using System.Windows.Shapes;

namespace GraphicsEditor
{
    public partial class MainWindow : Window
    {
        private SolidColorBrush currentBrush;
        private int brushSize;

        public MainWindow()
        {
            InitializeComponent();
            currentBrush = new SolidColorBrush(Colors.Black);
            brushSize = 5;

            // Настройка InkCanvas
            DrawingCanvas.DefaultDrawingAttributes.Color = Colors.Black;
            DrawingCanvas.DefaultDrawingAttributes.Width = brushSize;
            DrawingCanvas.DefaultDrawingAttributes.Height = brushSize;
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string colorName = selectedItem.Tag.ToString();
                currentBrush = (SolidColorBrush)new BrushConverter().ConvertFromString(colorName);
                DrawingCanvas.DefaultDrawingAttributes.Color = currentBrush.Color;
            }
        }

        private void BrushSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            brushSize = (int)e.NewValue;
            DrawingCanvas.DefaultDrawingAttributes.Width = brushSize;
            DrawingCanvas.DefaultDrawingAttributes.Height = brushSize;
        }

        private void Mode_Checked(object sender, RoutedEventArgs e)
        {
            if (DrawMode.IsChecked == true)
            {
                DrawingCanvas.EditingMode = InkCanvasEditingMode.Ink;
            }
            else if (EditMode.IsChecked == true)
            {
                DrawingCanvas.EditingMode = InkCanvasEditingMode.Select;
            }
            else if (EraseMode.IsChecked == true)
            {
                DrawingCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
            }
        }
    }
}